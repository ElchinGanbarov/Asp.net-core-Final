using System;
using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository.AboutRepository;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [TypeFilter(typeof(Auth))]
    public class AboutClaimController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAboutRepository _aboutRepository;
        public AboutClaimController(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
        public IActionResult Index()
        {
            var model = _aboutRepository.GetAboutClaim();
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.AboutUs = _aboutRepository.GetAboutFull();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AboutClaim model)
        {
            ViewBag.AboutUs = _aboutRepository.GetAboutFull();
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                model.AddedBy = _admin.Name;
                model.AddedDate = DateTime.Now;
                _aboutRepository.CreateAboutClaim(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.AboutUs = _aboutRepository.GetAboutFull();
            var model = _aboutRepository.AboutClaimById(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AboutClaim model)
        {
            ViewBag.AboutUs = _aboutRepository.GetAboutFull();
            var updateAboutClaim = _aboutRepository.AboutClaimById(model.Id);
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                updateAboutClaim.ModifiedBy = _admin.Name;
                updateAboutClaim.ModifiedDate = DateTime.Now;
                _aboutRepository.UpdateClaim(updateAboutClaim, model);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var claim = _aboutRepository.AboutClaimById(id);
            _aboutRepository.RemoveClaim(claim);
            var model = _aboutRepository.GetAboutClaim();
            return PartialView("index", model);
        }
    }
}