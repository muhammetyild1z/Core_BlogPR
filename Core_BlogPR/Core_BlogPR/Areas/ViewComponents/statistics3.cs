using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_BlogPR.Areas.ViewComponents
{
    public class statistics3 : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            Context c = new Context();
            var sessionId = id;

           
            ViewBag.image = c.Admins.Where(x=>x.adminID==sessionId).Select(y=>y.image).FirstOrDefault();
            ViewBag.shortAbout = c.Admins.Where(x=>x.adminID==sessionId).Select(y=>y.shortAbout).FirstOrDefault();
            return View();
        }
    }
}
