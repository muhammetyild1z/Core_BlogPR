using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.Areas.Admin.Controllers
{


    [Area("Admin")]
    [AllowAnonymous]

    public class BlogController : Controller
    {
        Context c = new Context();
        BlogManager bm = new BlogManager(new efBlogRepository());
        WriterManager wm = new WriterManager(new efWriterRepository());
        [HttpGet]
        public IActionResult Index(string searchBlog)
        {
            if (!string.IsNullOrEmpty(searchBlog))
            {
                return View(bm.GetLista(searchBlog));
            }
            var values = bm.GetList();

            return View(values);
        }
       
        public IActionResult Writer(string searchBlog)
        {
            if (!string.IsNullOrEmpty(searchBlog))
            {
                return View(wm.GetLista(searchBlog));
            }
            var values = wm.GetList();
            return View(values);
        }
    }


}
