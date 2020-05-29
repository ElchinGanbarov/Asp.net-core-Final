using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Allaia.Libs;
using AspFinal.Areas.Admin.Models.AboutModel;
using AspFinal.Areas.Admin.Models.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.AboutRepository;
using Repository.Repository.CategoryRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class AboutController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public AboutController(IAboutRepository aboutRepository, IMapper mapper, IFileManager fileManager)
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
            _fileManager = fileManager;
        }
        public IActionResult Index()
        {
            var abouts = _aboutRepository.GetFullAbouts();
            var model = _mapper.Map<IEnumerable<AboutUs>, IEnumerable<AboutModel>>(abouts);
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AboutModel model)
        {
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                var about = _mapper.Map<AboutModel, AboutUs>(model);
                about.AddedBy = _admin.Name;
                about.AddedDate = DateTime.Now;
                if (model.File != null)
                {
                    about.Image = _fileManager.Upload(model.File);

                }
                else
                {
                    about.Image = null;
                }
                _aboutRepository.AddAbout(about);
                return RedirectToAction("index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var about = _aboutRepository.GetAboutById(id);
            var model = _mapper.Map<AboutUs, AboutModel>(about);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AboutModel model)
        {
            var about = _mapper.Map<AboutModel, AboutUs>(model);

            if (model == null) return NotFound();

            if (ModelState.IsValid)
            {
                var updateAbout = _aboutRepository.GetAboutById(model.Id);

                updateAbout.ModifiedBy = _admin.Name;
                updateAbout.ModifiedDate = DateTime.Now;
                if (model.File == null)
                {
                    about.Image = updateAbout.Image;
                }
                else
                {
                    about.Image = _fileManager.Upload(model.File);
                }



                _aboutRepository.UpdateAbout(updateAbout, about);

                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var about = _aboutRepository.GetAboutById(id);
            _aboutRepository.RemoveAbout(about);
            if (about.Image != null)
            {
                _fileManager.Delete(about.Image);
            }

            var abouts = _aboutRepository.GetFullAbouts();
            var model = _mapper.Map<IEnumerable<AboutUs>, IEnumerable<AboutModel>>(abouts);
            return PartialView("index", model);
        }

    }
}