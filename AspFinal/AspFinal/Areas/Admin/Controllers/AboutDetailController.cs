using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.AboutRepository;
using Repository.Repository.CaseRepository;
using Repository.Repository.CategoryRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class AboutDetailController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAboutRepository _aboutRepository;
        public AboutDetailController(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
        public IActionResult Index()
        {
            var model = _aboutRepository.GetAboutDetail();
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.AboutUs = _aboutRepository.GetAboutFull();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AboutDetail model)
        {
            ViewBag.AboutUs = _aboutRepository.GetAboutFull();
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                model.AddedBy = _admin.Name;
                model.AddedDate = DateTime.Now;
                _aboutRepository.CreateAboutUs(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.AboutUs = _aboutRepository.GetAboutFull();
            var model = _aboutRepository.GetAboutUsById(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AboutDetail model)
        {
            ViewBag.AboutUs = _aboutRepository.GetAboutFull();
            var updateAboutDetail = _aboutRepository.GetAboutUsById(model.Id);
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                updateAboutDetail.ModifiedBy = _admin.Name;
                updateAboutDetail.ModifiedDate = DateTime.Now;
                _aboutRepository.UpdateDetail(updateAboutDetail, model);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var casespecs = _aboutRepository.GetAboutUsById(id);
            _aboutRepository.RemoveAboutDetail(casespecs);
            var model = _aboutRepository.GetAboutDetail();
            return PartialView("index", model);
        }
    }
}