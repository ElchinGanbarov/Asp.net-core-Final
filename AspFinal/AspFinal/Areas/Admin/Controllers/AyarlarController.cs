using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Allaia.Libs;
using AspFinal.Areas.Admin.Models.SettingView;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.BlogRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class AyarlarController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IBlogRepository _blogRepository;
        private readonly IFileManager _fileManager;
        private readonly IMapper _mapper;
        public AyarlarController(IBlogRepository blogRepository, IFileManager fileManager, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _fileManager = fileManager;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var settings = _blogRepository.GetStatusList();
            var model = _mapper.Map<IEnumerable<Settings>, IEnumerable<SettingViewModel>>(settings);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SettingViewModel model)
        {
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                var setting = _mapper.Map<SettingViewModel, Settings>(model);
                setting.AddedBy = _admin.Name;
                setting.AddedDate = DateTime.Now;
                if (model.CoverImageFile != null)
                {
                    setting.CoverImage = _fileManager.Upload(model.CoverImageFile);

                }
                else
                {
                    setting.CoverImage = null;
                }
                if (model.LogoFile != null)
                {
                    setting.Logo = _fileManager.Upload(model.LogoFile);

                }
                else
                {
                    setting.Logo = null;
                }
                if (model.LogoFile2 != null)
                {
                    setting.Logo2 = _fileManager.Upload(model.LogoFile2);

                }
                else
                {
                    setting.Logo2 = null;
                }
                _blogRepository.AddSetting(setting);
                return RedirectToAction("index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var setting = _blogRepository.GetSettingById(id);
            var model = _mapper.Map<Settings, SettingViewModel>(setting);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(SettingViewModel model)
        {
            var setting = _mapper.Map<SettingViewModel, Settings>(model);

            if (model == null) return NotFound();

            if (ModelState.IsValid)
            {
                var updateSetting = _blogRepository.GetSettingById(model.Id);

                updateSetting.ModifiedBy = _admin.Name;
                updateSetting.ModifiedDate = DateTime.Now;
                if (model.CoverImageFile == null)
                {
                    setting.CoverImage = updateSetting.CoverImage;
                }
                else
                {
                    setting.CoverImage = _fileManager.Upload(model.CoverImageFile);
                }
                if (model.LogoFile == null)
                {
                    setting.Logo = updateSetting.Logo;
                }
                else
                {
                    setting.Logo = _fileManager.Upload(model.LogoFile);
                }


                if (model.LogoFile2 != null)
                {
                    setting.Logo2 = _fileManager.Upload(model.LogoFile2);
                   
                }
                else
                {
                    setting.Logo2 = updateSetting.Logo2;
                }




                _blogRepository.UpdateSetting(updateSetting, setting);

                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var setting = _blogRepository.GetSettingById(id);
            _blogRepository.RemoveSetting(setting);
            if(setting.CoverImage != null)
            {
                _fileManager.Delete(setting.CoverImage);
            }
            if(setting.Logo != null)
            {
                _fileManager.Delete(setting.Logo);
            }
          

            var settings = _blogRepository.GetStatusList();
            var model = _mapper.Map<IEnumerable<Settings>, IEnumerable<SettingViewModel>>(settings);
            return PartialView("index", model);
        }
    }
}