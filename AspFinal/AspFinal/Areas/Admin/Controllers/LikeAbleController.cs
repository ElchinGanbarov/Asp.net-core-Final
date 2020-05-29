using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Allaia.Libs;
using AspFinal.Areas.Admin.Models.Agents;
using AspFinal.Areas.Admin.Models.BlogTables;
using AspFinal.Areas.Admin.Models.LikeAbles;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.AboutRepository;
using Repository.Repository.BlogRepository;
using Repository.Repository.CategoryRepository;
using Repository.Repository.HomeRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class LikeAbleController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public LikeAbleController(IAboutRepository aboutRepository, IMapper mapper, IFileManager fileManager)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
            _fileManager = fileManager;

        }
        public IActionResult Index()
        {
            var likeableareas = _aboutRepository.GetLikeAbleAreas();
            var model = _mapper.Map<IEnumerable<LikeableArea>, IEnumerable<LikeAbleAreasViewModel>>(likeableareas);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.About = _aboutRepository.GetAboutFull();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LikeAbleAreasViewModel model)
        {
            ViewBag.About = _aboutRepository.GetAboutFull();

            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                var like = _mapper.Map<LikeAbleAreasViewModel, LikeableArea>(model);
                like.AddedBy = _admin.Name;
                like.AddedDate = DateTime.Now;
                if (model.File != null)
                {
                    like.Photo = _fileManager.Upload(model.File);

                }
                else
                {
                    like.Photo = null;
                }
                _aboutRepository.AddLikeAble(like);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.About = _aboutRepository.GetAboutFull();

            var like = _aboutRepository.GetLikeAreById(id);
            var model = _mapper.Map<LikeableArea, LikeAbleAreasViewModel>(like);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LikeAbleAreasViewModel model)
        {
            var like = _mapper.Map<LikeAbleAreasViewModel, LikeableArea>(model);

            if (model == null) return NotFound();

            if (ModelState.IsValid)
            {
                var updateLike = _aboutRepository.GetLikeAreById(model.Id);

                updateLike.ModifiedBy = _admin.Name;
                updateLike.ModifiedDate = DateTime.Now;
                if (model.File != null)
                {
                    like.Photo = _fileManager.Upload(model.File);
                 
                }
                else
                {
                    like.Photo = updateLike.Photo;
                }



                _aboutRepository.UpdateLikeArea(updateLike, like);

                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var like = _aboutRepository.GetLikeAreById(id);
            _aboutRepository.RemoveLikeArea(like);
            if (like.Photo != null)
            {
                _fileManager.Delete(like.Photo);

            }
            var likeableareas = _aboutRepository.GetLikeAbleAreas();
            var model = _mapper.Map<IEnumerable<LikeableArea>, IEnumerable<LikeAbleAreasViewModel>>(likeableareas);
            return PartialView("index", model);
        }
    }
}