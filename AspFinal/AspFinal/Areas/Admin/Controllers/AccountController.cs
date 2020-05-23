using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Filters;
using AspFinal.Areas.Admin.Models.Account;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.AdminRepository;


namespace Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private Repository.Models.Admin _admin => RouteData.Values["Admin"] as Repository.Models.Admin;
        private readonly IAdminRepository _adminRepository;
        private readonly IMapper _mapper;
        public AccountController(IAdminRepository adminRepository, IMapper mapper)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
        }
        
        [HttpGet]
        //[Microsoft.AspNetCore.Mvc.Route("register")]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel model)
        {
            bool CheckEmail = _adminRepository.CheckEmail(model.Email);
            if (CheckEmail)
            {
                ModelState.AddModelError("Email", "Bu E-mail artiq movcuddur");
            }
            if (ModelState.IsValid)
            {
                var admin = _mapper.Map<RegisterViewModel, Repository.Models.Admin>(model);
                admin.Status = true;
                admin.Token = Guid.NewGuid().ToString();
                _adminRepository.Register(admin);

                Response.Cookies.Append("admin-token", admin.Token, new Microsoft.AspNetCore.Http.CookieOptions
                {
                    HttpOnly = true,
                    Expires = DateTime.Now.AddYears(1)
                });

                return RedirectToAction("login");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
              Repository.Models.Admin admin = _adminRepository.Login(model.Email, model.Password);

                if (admin != null)
                {
                    admin.Token = Guid.NewGuid().ToString();
                    Response.Cookies.Delete("admin-token");
                    Response.Cookies.Append("admin-token", admin.Token, new Microsoft.AspNetCore.Http.CookieOptions
                    {
                        Expires = model.RememberMe ? DateTime.Now.AddYears(1) : DateTime.Now.AddDays(1),
                        HttpOnly = true
                    });
                    _adminRepository.UpdateToken(admin.Id, admin.Token);

                    return RedirectToAction("index", "dashboard");
                }
                else
                {
                    ModelState.AddModelError("Password", "E-mail ve ya sifre yanlisdir");

                }
            }

            return View(model);
        }
        public IActionResult Logout()
        {
            Request.Cookies.TryGetValue("admin-token", out string token);
            var user = _adminRepository.CheckByToken(token);
            _adminRepository.UpdateToken(user.Id, null);
            return RedirectToAction("login");
        }
    }
}