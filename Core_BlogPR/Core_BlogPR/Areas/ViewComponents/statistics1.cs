using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.Areas.ViewComponents
{
    public class statistics1:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BlogManager bm = new BlogManager(new efBlogRepository());
            Context c = new Context();
            // var values = c.Blogs.Where(x => x.blogCreateDate <= DateTime.Now).Take(2).ToList();
            var values = bm.GetListeWriter().OrderByDescending(y=>y.blogCreateDate).Where(x => x.blogCreateDate <= DateTime.Now).Take(2).ToList();
            return View(values);
        }
    }
}
