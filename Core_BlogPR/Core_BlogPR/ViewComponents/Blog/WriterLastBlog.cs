using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {
        BlogManager bm = new BlogManager(new efBlogRepository());

        public IViewComponentResult Invoke(int id)
        {
            BlogManager cm = new BlogManager(new efBlogRepository());
            Context c = new Context();
            var values = cm.GetLast4PostWriter();
            //  List<int> count = c.Blogs.Where(x => x.catagoryID == c.Catagoies.Select(y => y.catagoryID).FirstOrDefault()).Count();
            var a = c.Blogs.Where(y => y.blogID == id).Select(x => x.writerID).FirstOrDefault();
            ViewBag.v = c.Writers.Where(x => x.writerID == a).Select(y=>y.writerID).FirstOrDefault();
            return View(values);
        }
    }
}
