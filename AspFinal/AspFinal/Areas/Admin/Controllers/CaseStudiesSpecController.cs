using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.CaseRepository;
using Repository.Repository.CategoryRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class CaseStudiesSpecController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ICaseRepository _caseRepository;
        public CaseStudiesSpecController(ICaseRepository caseRepository)
        {
            _caseRepository = caseRepository;
        }
        public IActionResult Index()
        {
            var model = _caseRepository.GetFullCaseSpecs();
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.CaseStudies = _caseRepository.GetCaseStudiesFull();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CaseStudiesSpec model)
        {
            ViewBag.CaseStudies = _caseRepository.GetCaseStudiesFull();
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                model.AddedBy = _admin.Name;
                model.AddedDate = DateTime.Now;
                _caseRepository.CreateCaseSpecs(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.CaseStudies = _caseRepository.GetCaseStudiesFull();
            var model = _caseRepository.GetCaseSpecsById(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CaseStudiesSpec model)
        {
            ViewBag.CaseStudies = _caseRepository.GetCaseStudiesFull();
            var updateCasespecs = _caseRepository.GetCaseSpecsById(model.Id);
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                updateCasespecs.ModifiedBy = _admin.Name;
                updateCasespecs.ModifiedDate = DateTime.Now;
                _caseRepository.UpdateCaseSpecs(updateCasespecs, model);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var casespecs = _caseRepository.GetCaseSpecsById(id);
            _caseRepository.RemoveCasespecsId(casespecs);
            var model = _caseRepository.GetFullCaseSpecs();
            return PartialView("index", model);
        }
    }
}