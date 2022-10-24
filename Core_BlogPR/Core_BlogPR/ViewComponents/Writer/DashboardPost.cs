using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_BlogPR.ViewComponents.Writer
{
    public class DashboardPost:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            BlogManager bm = new BlogManager(new efBlogRepository());
            Context c = new Context();

            var values = c.Blogs.Where(x => x.writerID == id);
            
            // giriş yapan yazarın idsini çekip 4 postunu getirecek

            return View(values);

        }
    }
}
