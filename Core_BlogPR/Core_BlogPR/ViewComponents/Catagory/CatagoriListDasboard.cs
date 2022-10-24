using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.ViewComponents.Catagory
{
    public class CatagoriListDasboard:ViewComponent
    {
        CatagoryManager cm = new CatagoryManager(new efCatagoryRepository());
        public IViewComponentResult Invoke()
        {
            
            return View(cm.GetList());
        }
    }
}
