using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_BlogPR.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllNoticifation()
        {
            NotificationManager nm= new NotificationManager(new efNotificationRepository());
            ViewBag.writerImage = User.Claims.Where(x => x.Type == ClaimTypes.GivenName).FirstOrDefault().Value;
            var values = nm.GetList();
            return View(values);
        }
    }
}
