using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_BlogPR.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        CatagoryManager cm = new CatagoryManager(new efCatagoryRepository());
        BlogManager bm =new BlogManager(new efBlogRepository());
        Context c = new Context();

        public IActionResult Index()
        {
            var values = bm.GetBlogAndCatagoryList();


          
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            // Yorum var mı?
            var a = c.Comments.Where(x => x.blogID == id).Count();
            if (a==0)
            {
                ViewBag.i1 = "Bu Yazı İçin Henüz Bir Yorum Bulunmamaktdır.";
            }
            //view tarafından component sınıfına id göndermek
            ViewBag.i = id;          
            //hangi blogu hangi yazar yazdı
            var writer = c.Blogs.Where(x => x.blogID == id).Select(y=> y.writerID).FirstOrDefault();
            ViewBag.writerid = writer;
            var values = bm.GetBlogByIDList(id);
            ViewBag.commentCount = c.Comments.Where(x => x.blogID == id).Count();
            ViewBag.b = c.Blogs.Where(x => x.blogID == id).Select(y => y.catagoryID).FirstOrDefault() ;
            
                     
            return View(values);
        }

       

    }
}
