using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.ViewComponents.Blog
{
    public class Last3Post:ViewComponent
    {
        BlogManager bm = new BlogManager(new efBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.GetLast3Post();
            return View(values);
        }
    }
}
