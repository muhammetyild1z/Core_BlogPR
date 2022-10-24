using BusinessLayer.Concrete;
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
    public class CommentController : Controller
    {
       
        CommentManager cm = new CommentManager(new efCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult AddCommnet(int id)
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult AddCommnet(Comment p)
        {

            p.BlogScore = 0;
            p.commentStatus = true;
            p.commentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            cm.Add(p);

            return RedirectToAction("Index","Blog");
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            
            var values= cm.GetLista(id);
            return PartialView(values);
        }
    }
}
