using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using Allaia.Libs;
using AspFinal.Areas.Admin.Models.Agents;
using AspFinal.Areas.Admin.Models.BlogTables;
using AspFinal.Areas.Admin.Models.CaseStudies;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.BlogRepository;
using Repository.Repository.CaseRepository;
using Repository.Repository.CategoryRepository;
using Repository.Repository.HomeRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class CaseStudiesController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly ICaseRepository _caseRepository;
        private readonly IMapper _mapper;
        private readonly IFileManager _fileManager;
        public CaseStudiesController(ICaseRepository caseRepository, IMapper mapper, IFileManager fileManager)
        {
            _caseRepository = caseRepository;
            _mapper = mapper;
            _fileManager = fileManager;

        }
        public IActionResult Index()
        {
            var cases = _caseRepository.GetCaseStudiesFull();
            var model = _mapper.Map<IEnumerable<CaseStudiesSingle>, IEnumerable<CaseStudiesViewModel>>(cases);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CaseStudiesViewModel model)
        {
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                var cases = _mapper.Map<CaseStudiesViewModel, CaseStudiesSingle>(model);
                cases.AddedBy = _admin.Name;
                cases.AddedDate = DateTime.Now;
                if (model.File != null)
                {
                    cases.Image = _fileManager.Upload(model.File);

                }
                else
                {
                    cases.Image = null;
                }
                _caseRepository.AddCasesStudies(cases);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var cases = _caseRepository.GetCasesById(id);
            var model = _mapper.Map<CaseStudiesSingle, CaseStudiesViewModel>(cases);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CaseStudiesViewModel model)
        {
            var cases = _mapper.Map<CaseStudiesViewModel, CaseStudiesSingle>(model);

            if (model == null) return NotFound();

            if (ModelState.IsValid)
            {
                var updateCase = _caseRepository.GetCasesById(model.Id);

                updateCase.ModifiedBy = _admin.Name;
                updateCase.ModifiedDate = DateTime.Now;
                if (model.File == null)
                {
                    cases.Image = updateCase.Image;
                }
                else
                {
                    cases.Image = _fileManager.Upload(model.File);
                }



                _caseRepository.UpdateCases(updateCase, cases);

                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var cases = _caseRepository.GetCasesById(id);
            _caseRepository.RemoveCases(cases);
            if (cases.Image != null)
            {
                _fileManager.Delete(cases.Image);

            }
            var casess = _caseRepository.GetCaseStudiesFull();
            var model = _mapper.Map<IEnumerable<CaseStudiesSingle>, IEnumerable<CaseStudiesViewModel>>(casess);
            return PartialView("index", model);
        }
    }
}