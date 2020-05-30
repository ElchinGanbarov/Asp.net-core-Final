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
    public class ContactController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly  IAboutRepository _aboutRepository;
        public ContactController(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
        public IActionResult Index()
        {
            var model = _aboutRepository.GetContactUs();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ContactUss model)
        {
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                model.AddedBy = _admin.Name;
                model.AddedDate = DateTime.Now;
                _aboutRepository.ContactCreat(model);
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _aboutRepository.GetContactById(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ContactUss model)
        {
            var updatecontact = _aboutRepository.GetContactById(model.Id);
            if (model == null) return NotFound();
            if (ModelState.IsValid)
            {
                updatecontact.ModifiedBy = _admin.Name;
                updatecontact.ModifiedDate = DateTime.Now;
                _aboutRepository.UpdateContact(updatecontact, model);
                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Remove(int id)
        {
            var contact = _aboutRepository.GetContactById(id);
            _aboutRepository.RemoveContact(contact);
            var model = _aboutRepository.GetContactUs();
            return PartialView("index", model);
        }
    }
}