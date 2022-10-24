using BusinessLayer.Concrete;
using BusinessLayer.RulesValidation;
using Core_BlogPR.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new efWriterRepository());
        Context c = new Context();
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p, IFormCollection form, AddProfieImage a )
        {
            WriterRules WR = new WriterRules();
            ValidationResult result = WR.Validate(p);
            string[] str = form["checkbox"].ToArray();
            var repeat = form["PasswordRepeat"].ToString();
            var mailkontrol = c.Writers.Where(x => x.mail == p.mail).Count();
          
             if (repeat != p.password)
            {
                ViewBag.registersifre = " Şifreler Eşleşmiyor.";
                return View();
            }
            else if (mailkontrol>0)
            {
                ViewBag.registermail = " Bu mail daha önce kayıt edilmiş.";
                return View();
            }
            else if (str.Length == 0)
           
            {
                ViewBag.registerhata1 = 1;
                ViewBag.registerhata = " Şartları kabul etmeniz gerekmektedir.";
                return View();

            }
            else if (str.Length == 1 && repeat == p.password && result.IsValid)
            {
                Writer w = new Writer();
                if (a.writerImage!=null)
                {
                   
                    p.writerAbout = "otomatik kayıt";
                    p.writerStatus = true;
                    
                    var extension = Path.GetExtension(a.writerImage.FileName);
                    var newImageName = Guid.NewGuid() + extension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AddProfileImage/", newImageName);
                    var stream = new FileStream(location, FileMode.Create);
                    a.writerImage.CopyToAsync(stream);
                    w.writerImage = newImageName;
                    w.writerAbout = p.writerAbout;
                    w.mail = p.mail;
                    w.writerName = p.writerName;
                    w.password = p.password;
                    w.writerStatus = true;

                    wm.Add(w);
                    return RedirectToAction("Index", "Blog");
                }
                else
                {
                    ViewBag.Image = "Image boş geçilemez";
                    return View();
                }
               
               
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);

                }
                return View();
            }


        }
    }
}
