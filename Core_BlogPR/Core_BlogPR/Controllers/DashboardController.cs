using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_BlogPR.Controllers
{
    public class DashboardController : Controller
    {
        CatagoryManager cm = new CatagoryManager(new efCatagoryRepository());
        BlogManager bm = new BlogManager(new efBlogRepository());
        Context c = new Context();
        [AllowAnonymous]
        public IActionResult Index()
        {
            var values = bm.GetBlogAndCatagoryList();
            if (User.Identity.IsAuthenticated == true)
            {
                var sessionId = Convert.ToInt32(User.Claims.Where(x => x.Type == ClaimTypes.Role).FirstOrDefault().Value);
                // var datelast7 = c.Blogs.Where(y => y.writerID == sessionId).Where(x => x.blogCreateDate.AddDays(7) >= DateTime.Now).Count();
                //yukardeki giriş yapan kişiye özel yazılan blog sayısını bulur...       


                ViewBag.writertoplamBlog = bm.GetList().Where(x => x.writerID == sessionId).Count();
                ViewBag.BlogToplam = bm.GetList().Count();
                ViewBag.last7DaysBlog = c.Blogs.Where(x => x.blogCreateDate.AddDays(7) >= DateTime.Now).Count();
                ViewBag.sessionId = sessionId;
                ViewBag.writerAbout = User.Claims.Where(x => x.Type == ClaimTypes.Surname).FirstOrDefault().Value;
                ViewBag.writerImage = User.Claims.Where(x => x.Type == ClaimTypes.GivenName).FirstOrDefault().Value;

            }
            else
            {
                return RedirectToAction("Error", "Error");
            }

            return View(values);
        }
    }
}
