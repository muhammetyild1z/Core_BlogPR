using BusinessLayer.Concrete;
using BusinessLayer.RulesValidation;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
namespace Core_BlogPR.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    
    public class CatagoryController : Controller
    {
        Context c = new Context();
        CatagoryManager cm = new CatagoryManager(new efCatagoryRepository());
       
       
        public IActionResult Index(int page = 1)
        {
            var values = cm.GetList().ToPagedList(page,7);
            return View(values);
        }
        [HttpGet]
        public IActionResult CatagoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CatagoryAdd(Catagory p)
        {
           
            CatagoryRules rs = new CatagoryRules();
            ValidationResult result = rs.Validate(p);
            if (result.IsValid)
            {
                p.catagoryStatus = true;
                cm.Add(p);
                return View();
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
                return View();
            }        
        }

        public IActionResult Pasif(int id)
        {
          
            var status = c.Catagoies.Find(id);

            if (status.catagoryStatus==true)
            {
                status.catagoryStatus = false;
                c.SaveChanges();
            }
          
            return RedirectToAction("Index", "Catagory");
        }
        public IActionResult Aktif(int id)
        {
           
            var status = c.Catagoies.Find(id);

            if (status.catagoryStatus == false)
            {
                status.catagoryStatus = true;
                c.SaveChanges();
            }
           
            return RedirectToAction("Index", "Catagory");
        }

        [HttpGet]
        public IActionResult CatagoryEdit(int id)
        {
           
            var catagory = c.Catagoies.Find(id);
            return View(catagory);
        }
        [HttpPost]
        public IActionResult CatagoryEdit(Catagory p)
        {
           
            Catagory cat = new Catagory();
            var values = c.Catagoies.Where(x => x.catagoryID == p.catagoryID).Select(y => y.catagoryStatus).FirstOrDefault(); 
            cat.catagoryID = p.catagoryID;
            cat.catagoryName = p.catagoryName;
            cat.catagoryDesc = p.catagoryDesc;
            cat.catagoryStatus = values;
            cm.Update(cat);

            return RedirectToAction("Index", "Catagory");
        }
    }
}
