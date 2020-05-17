using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspFinal.Controllers
{
    public class CaseController : Controller
    {
        public IActionResult CaseStudies()
        {
            return View();
        }
        public IActionResult CaseSingle()
        {
            return View();
        }
    }
}