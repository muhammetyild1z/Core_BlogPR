using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
       
        AboutManager am = new AboutManager(new efAboutRepository());

        public AboutManager Am { get => am; set => am = value; }
      
        public IActionResult Index(int id)
        {
            var values = Am.GetList();
            return View(values);
        }


        public PartialViewResult SocialMediaAbout()
        {
           
            return PartialView();
        }
    }
}
