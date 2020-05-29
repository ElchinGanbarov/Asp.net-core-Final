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
    public class TagsController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAboutRepository _aboutRepository;
        public TagsController(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
        public IActionResult Index()
        {
            var model = _aboutRepository.GetTags();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tags model)
        {
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                model.AddedBy = _admin.Name;
                model.AddedDate = DateTime.Now;
                _aboutRepository.TagCreat(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _aboutRepository.GetTagsById(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Tags model)
        {
            var updatetag = _aboutRepository.GetTagsById(model.Id);
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                updatetag.ModifiedBy = _admin.Name;
                updatetag.ModifiedDate = DateTime.Now;
                _aboutRepository.UpdateTag(updatetag, model);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var tags = _aboutRepository.GetTagsById(id);
            _aboutRepository.RemoveTags(tags);
            var model = _aboutRepository.GetTags();
            return PartialView("index", model);
        }
    }
}