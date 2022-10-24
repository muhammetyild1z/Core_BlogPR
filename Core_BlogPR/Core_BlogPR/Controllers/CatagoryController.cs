using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.Controllers
{
    public class CatagoryController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
