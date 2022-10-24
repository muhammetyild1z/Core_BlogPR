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
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_BlogPR.Controllers
{

    [AllowAnonymous]
    public class WriterController : Controller
    {
        BlogManager bm = new BlogManager(new efBlogRepository());
        WriterManager wm = new WriterManager(new efWriterRepository());
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult WriterProfileEdit()
        {
            var writerValues = wm.GetByID(Convert.ToInt32(User.Claims.Where(x => x.Type == ClaimTypes.Role).First().Value));
            ViewBag.writerImage = User.Claims.Where(x => x.Type == ClaimTypes.GivenName).FirstOrDefault().Value;
            return View(writerValues);
        }
        [HttpPost]
        public IActionResult WriterProfileEdit(Writer p, WriterEditProfile w)
        {
            WriterRules rs = new WriterRules();
            ValidationResult result = rs.Validate(p);
            Writer wr = new Writer();

            //  if (result.IsValid)
            //   {
            //eski profil fotografını sime işlemi eklenecek
            var extension = Path.GetExtension(w.writerImage.FileName);
            var newProfileImage = Guid.NewGuid() + extension;
            var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AddProfileImage/", newProfileImage);
            var stream = new FileStream(location, FileMode.Create);
            w.writerImage.CopyToAsync(stream);
            wr.writerID = p.writerID;
            wr.writerImage = newProfileImage;
            wr.writerAbout = p.writerAbout;
            wr.mail = p.mail;
            wr.writerName = p.writerName;
            wr.password = p.password;
            wr.writerStatus = p.writerStatus;

            wm.Update(wr);
            return RedirectToAction("Index", "Dashboard");
            //  }
            //   else
            //  {
            //    foreach (var item in result.Errors)
            //     {
            //       ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //  }

            // return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }

        public PartialViewResult Sidebar()
        {
            return PartialView();
        }

        public IActionResult BlogListByWriter()
        {
            var values = bm.GetWithCatagoryByWriterBM(Convert.ToInt32(User.Claims.Where(x => x.Type == ClaimTypes.Role).First().Value));
            ViewBag.userid = values;

            ViewBag.writerAbout = User.Claims.Where(x => x.Type == ClaimTypes.Surname).FirstOrDefault().Value;
            ViewBag.writerImage = User.Claims.Where(x => x.Type == ClaimTypes.GivenName).FirstOrDefault().Value;
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            ViewBag.writerAbout = User.Claims.Where(x => x.Type == ClaimTypes.Surname).FirstOrDefault().Value;
            ViewBag.writerImage = User.Claims.Where(x => x.Type == ClaimTypes.GivenName).FirstOrDefault().Value;
            CatagoryManager cm = new CatagoryManager(new efCatagoryRepository());
            List<SelectListItem> catagoriesValue = (from x in cm.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.catagoryName,
                                                        Value = x.catagoryID.ToString()

                                                    }).ToList();
            ViewBag.cv = catagoriesValue;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog p, AddBlogImage b)
        {
            BlogRules br = new BlogRules();
            ValidationResult results = br.Validate(p);
            if (results.IsValid)
            {
                Blog blog = new Blog();
                var extension = Path.GetExtension(b.blogThumbnailImage.FileName);
                var newBlogImageUrl = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AddBlogImage/", newBlogImageUrl);
                var stream = new FileStream(location, FileMode.Create);
                b.blogThumbnailImage.CopyToAsync(stream);
                p.blogThumbnailImage = newBlogImageUrl;
                p.blogSmallImage = newBlogImageUrl;
                p.blogStatus = true;
                p.blogCreateDate = DateTime.Now;
                p.writerID = Convert.ToInt32(User.Claims.Where(x => x.Type == ClaimTypes.Role).FirstOrDefault().Value);
                bm.Add(p);
                return RedirectToAction("BlogListByWriter", "Writer");
            }
            else

            {
                // p.writerID = Convert.ToInt32(User.Claims.Where(x => x.Type == ClaimTypes.Role).FirstOrDefault().Value);
                // hata mesajı gelmiyor!!!!
                foreach (var item in results.Errors)
                {

                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }

                return View();
            }
        }

        [HttpGet]
        public IActionResult BlogEdit(int id)
        {
            CatagoryManager cm = new CatagoryManager(new efCatagoryRepository());
            List<SelectListItem> catagoriesValue = (from x in cm.GetList()
                                                    select new SelectListItem
                                                    {
                                                        Text = x.catagoryName,
                                                        Value = x.catagoryID.ToString()

                                                    }).ToList();
            ViewBag.cv = catagoriesValue;
            Context c = new Context();
            var values = c.Blogs.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult BlogEdit(Blog p)
        {
            BlogRules br = new BlogRules();
            ValidationResult results = br.Validate(p);
            if (results.IsValid)
            {

                p.blogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                // session
                p.writerID = 1;
                //Convert.ToInt32( User.Claims.Where(x => x.Type == ClaimTypes.Role).FirstOrDefault().Value);
                bm.Update(p);
                return RedirectToAction("BlogListByWriter", "Writer");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
        public IActionResult BlogDelete(int id)
        {
            Context c = new Context();

            var deger = c.Blogs.Find(id);
            if (deger.blogStatus == true)
            {
                deger.blogStatus = false;
                c.SaveChanges();
            }
            else if (deger.blogStatus == false)
            {
                deger.blogStatus = true;
                c.SaveChanges();
            }
            return RedirectToAction("BlogListByWriter");

        }
        [HttpGet]
        public IActionResult PasswordUpdate()
        {
            var values = wm.GetByID(Convert.ToInt32(User.Claims.Where(x => x.Type == ClaimTypes.Role).FirstOrDefault().Value));
            ViewBag.writerImage = User.Claims.Where(x => x.Type == ClaimTypes.GivenName).FirstOrDefault().Value;
            return View(values);
        }
        [HttpPost]
        public IActionResult PasswordUpdate(Writer p, IFormCollection frm)
        {
            // rules eklenecek
            var oldpassword = frm["writerPassword"];
            var password = frm["password"];
            var repeatPassword = frm["repeatPassword"];

            if (oldpassword == p.password)
            {
                if (password == repeatPassword)
                {
                    /// işlem kıslat!
                    var id = Convert.ToInt32(User.Claims.Where(x => x.Type == ClaimTypes.Role).FirstOrDefault().Value);
                    p.writerID = id;
                    p.writerImage = c.Writers.Where(x => x.writerID == id).Select(y => y.writerImage).FirstOrDefault();
                    p.mail = c.Writers.Where(x => x.writerID == id).Select(y => y.mail).FirstOrDefault();
                    p.writerAbout = c.Writers.Where(x => x.writerID == id).Select(y => y.writerAbout).FirstOrDefault();
                    p.writerName = c.Writers.Where(x => x.writerID == id).Select(y => y.writerName).FirstOrDefault();
                    p.writerStatus = c.Writers.Where(x => x.writerID == id).Select(y => y.writerStatus).FirstOrDefault();
                    p.password = frm["password"];
                    wm.Update(p);

                    return RedirectToAction("Index", "Dashboard");
                }
            }
            else
            {
                ViewBag.sifreUyusmaz = "Şifreler uyuşmuyor veya eski şifre yanlış..";
            }
            return View();
        }

    }
}
