using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_BlogPR.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class WidgetsController : Controller
    {
        public IActionResult Index()
        {
           ViewBag.id =Convert.ToInt32( User.Claims.Where(x=>x.Type== ClaimTypes.NameIdentifier).First().Value);
            return View();
        }
    }
}
