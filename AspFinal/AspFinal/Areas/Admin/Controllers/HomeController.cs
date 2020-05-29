using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Admin.Filters;
using Allaia.Libs;
using AspFinal.Areas.Admin.Models.HomeImages;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.HomeRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class HomeController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IHomeRepository _homeRepository;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public HomeController(IHomeRepository homeRepository,IMapper mapper, IFileManager fileManager)
        {
            _homeRepository = homeRepository;
            _mapper = mapper;
            _fileManager = fileManager;
        }
        public IActionResult Index()
        {
            var homeslider = _homeRepository.GetFullHomeSlider();
            var model=_mapper.Map<IEnumerable<HomeSlider>,IEnumerable< SlideViewModel >> (homeslider);
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SlideViewModel model)
        {
            if (model == null) return NotFound();
            var homeslider = _mapper.Map<SlideViewModel, HomeSlider>(model);
            if (ModelState.IsValid)
            {
                homeslider.AddedBy = _admin.Name;
                homeslider.AddedDate = DateTime.Now;
                if (model.File != null)
                {
                    homeslider.Image = _fileManager.Upload(model.File);
                }
                else
                {
                    homeslider.Image = null;
                }
              
                _homeRepository.CreateHomeSlider(homeslider);
                return RedirectToAction("index");
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            var homesileder = _homeRepository.GEtHomeSliderById(id);
            var model = _mapper.Map<HomeSlider, SlideViewModel>(homesileder);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SlideViewModel model)
        {
            if (model == null) return NotFound();
            var slide = _mapper.Map<SlideViewModel, HomeSlider>(model);
            if (ModelState.IsValid)
            {
                var updateslide = _homeRepository.GEtHomeSliderById(model.Id);
                if(model.File == null)
                {
                    slide.Image = updateslide.Image;
                }
                else
                {
                    slide.Image = _fileManager.Upload(model.File);
                }
             
                    
                
                updateslide.ModifiedBy = _admin.Name;
                updateslide.ModifiedDate = DateTime.Now;
                _homeRepository.UpdateSlide(updateslide, slide);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var slide = _homeRepository.GEtHomeSliderById(id);
            if(slide != null)
            {
                _fileManager.Delete(slide.Image);
            }
          
            _homeRepository.DeleteSlide(slide);
            var homeslider = _homeRepository.GetFullHomeSlider();
            var model = _mapper.Map<IEnumerable<HomeSlider>, IEnumerable<SlideViewModel>>(homeslider);
            return PartialView("index",model);
        }
    }
}