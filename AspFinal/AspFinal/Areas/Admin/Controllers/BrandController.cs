using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Allaia.Libs;
using AspFinal.Areas.Admin.Models.Agents;
using AspFinal.Areas.Admin.Models.BrandView;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.AboutRepository;
using Repository.Repository.CategoryRepository;
using Repository.Repository.HomeRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class BrandController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAboutRepository _aboutRepository;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public BrandController(IAboutRepository aboutRepository, IMapper mapper, IFileManager fileManager )
        {
            _aboutRepository = aboutRepository;
            _mapper = mapper;
            _fileManager = fileManager;
        }
        public IActionResult Index()
        {
            var brands = _aboutRepository.GetBrandsAll();
            var model = _mapper.Map<IEnumerable<Brand>, IEnumerable<BrandViewModel>>(brands);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BrandViewModel model)
        {
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                var brand = _mapper.Map<BrandViewModel, Brand>(model);
                brand.AddedBy = _admin.Name;
                brand.AddedDate = DateTime.Now;
                if (model.File != null)
                {
                    brand.Logo = _fileManager.Upload(model.File);

                }
                else
                {
                    brand.Logo = null;
                }
                _aboutRepository.AddBrand(brand);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var agent = _aboutRepository.GetBrandById(id);
            var model = _mapper.Map<Brand, BrandViewModel>(agent);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BrandViewModel model)
        {
            var brand = _mapper.Map<BrandViewModel, Brand>(model);

            if (model == null) return NotFound();

            if (ModelState.IsValid)
            {
                var updateBrand = _aboutRepository.GetBrandById(model.Id);

                updateBrand.ModifiedBy = _admin.Name;
                updateBrand.ModifiedDate = DateTime.Now;
                if (model.File == null)
                {
                    brand.Logo = updateBrand.Logo;
                }
                else
                {
                    brand.Logo = _fileManager.Upload(model.File);

                }
                _aboutRepository.UpdateBrand(updateBrand, brand);

                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var brand = _aboutRepository.GetBrandById(id);
            _aboutRepository.RemoveBrand(brand);
            if (brand.Logo != null)
            {
                _fileManager.Delete(brand.Logo);

            }
            var brands = _aboutRepository.GetBrandsAll();
            var model = _mapper.Map<IEnumerable<Brand>, IEnumerable<BrandViewModel>>(brands);
            return PartialView("index", model);
        }
    }
}