using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_BlogPR.Areas.ViewComponents
{
    public class statistics:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            Context c = new Context();

            BlogManager bm = new BlogManager(new efBlogRepository());
            var values = bm.GetList();
            ViewBag.notification = c.notifications.Count();
            ViewBag.commentCount = c.Comments.Count();

            string city = c.Admins.Where(x => x.adminID == id).Select(y => y.sehir).FirstOrDefault();
            string api = "1df333ef140dd87965876091a0f1229b";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q="+city+"&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument document = XDocument.Load(connection);
            ViewBag.weader = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.city = city;
            return View(values);
        }
    }
}
