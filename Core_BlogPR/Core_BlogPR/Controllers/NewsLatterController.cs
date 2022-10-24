using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.Controllers
{
    [AllowAnonymous]
    public class NewsLatterController : Controller
    {
       
        INewsLatterManager nb = new INewsLatterManager(new efNewsLatterRepository());

        [HttpGet]
        public PartialViewResult subscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public RedirectToActionResult subscribeMail(NewsLatter p , int id)
        {
            p.mailStatus = true;
            nb.Add(p);
          // ViewBag.js = "swal('Good job!', 'You clicked the button!', 'success');";
            return RedirectToAction("Index","Blog") ;
        }
    }
}
