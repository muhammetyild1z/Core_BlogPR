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
    public class BlogListDasboard:ViewComponent
    {
        BlogManager bm = new BlogManager(new efBlogRepository());

        public IViewComponentResult Invoke()
        {
           
            var values = bm.GetLast4PostWriter();
            
            //  List<int> count = c.Blogs.Where(x => x.catagoryID == c.Catagoies.Select(y => y.catagoryID).FirstOrDefault()).Count();

            return View(values);

        }
         
    }
}
