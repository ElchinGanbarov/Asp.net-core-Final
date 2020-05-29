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
    public class FaqController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ICaseRepository _caseRepository;
        public FaqController(ICaseRepository caseRepository)
        {
            _caseRepository = caseRepository;
        }
        public IActionResult Index()
        {
            var model = _caseRepository.GetFaqsFull();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FAQ model)
        {
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                model.AddedBy = _admin.Name;
                model.AddedDate = DateTime.Now;
                _caseRepository.FaqCreate(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _caseRepository.GetFaqsById(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(FAQ model)
        {
            var updatefaq = _caseRepository.GetFaqsById(model.Id);
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                updatefaq.ModifiedBy = _admin.Name;
                updatefaq.ModifiedDate = DateTime.Now;
                _caseRepository.UpdateFaq(updatefaq, model);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var faqs = _caseRepository.GetFaqsById(id);
            _caseRepository.RemoveFaqs(faqs);
            var model = _caseRepository.GetFaqsFull();
            return PartialView("index", model);
        }
    }
}