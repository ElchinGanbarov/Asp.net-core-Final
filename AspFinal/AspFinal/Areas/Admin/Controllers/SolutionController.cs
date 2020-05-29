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
    public class SolutionController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ICaseRepository _caseRepository;
        public SolutionController(ICaseRepository caseRepository)
        {
            _caseRepository = caseRepository;
        }
        public IActionResult Index()
        {
            var model = _caseRepository.GetFullsSOlition();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Solution model)
        {
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                model.AddedBy = _admin.Name;
                model.AddedDate = DateTime.Now;
                _caseRepository.SolutionCreat(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _caseRepository.GetSolutionById(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Solution model)
        {
            var updatesolution = _caseRepository.GetSolutionById(model.Id);
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                updatesolution.ModifiedBy = _admin.Name;
                updatesolution.ModifiedDate = DateTime.Now;
                _caseRepository.UpdateSolution(updatesolution, model);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var solution = _caseRepository.GetSolutionById(id);
            _caseRepository.RemoveSolution(solution);
            var model = _caseRepository.GetFullsSOlition();
            return PartialView("index", model);
        }
    }
}