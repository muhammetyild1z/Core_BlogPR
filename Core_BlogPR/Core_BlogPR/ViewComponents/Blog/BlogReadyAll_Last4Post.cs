using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.ViewComponents.Writer
{
    public class BlogReadyAll_Last4Post:ViewComponent
    {
        BlogManager bm = new BlogManager(new efBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.GetLast4PostWriter();
            return View(values);
        }
    }
}
