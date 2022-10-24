using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.ViewComponents
{
    public class CatagoryLeftList : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            
           CatagoryManager cm = new CatagoryManager(new efCatagoryRepository());
           
            
            return View(cm.GetCatagoryandBlog());

        }

    }
}
