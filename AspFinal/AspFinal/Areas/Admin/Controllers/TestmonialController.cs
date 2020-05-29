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
    public class TestmonialController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAboutRepository  _aboutRepository;
        public TestmonialController(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
        public IActionResult Index()
        {
            var model = _aboutRepository.GetTestmonials();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Testimonial model)
        {
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                model.AddedBy = _admin.Name;
                model.AddedDate = DateTime.Now;
                _aboutRepository.CreatTestmonial(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _aboutRepository.TestmonialById(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Testimonial model)
        {
            var updatetestmonial = _aboutRepository.TestmonialById(model.Id);
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                updatetestmonial.ModifiedBy = _admin.Name;
                updatetestmonial.ModifiedDate = DateTime.Now;
                _aboutRepository.TestmonialUpdate(updatetestmonial, model);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var testmonial = _aboutRepository.TestmonialById(id);
            _aboutRepository.RemoveTestmonial(testmonial);
            var model = _aboutRepository.GetTestmonials();
            return PartialView("index", model);
        }
    }
}