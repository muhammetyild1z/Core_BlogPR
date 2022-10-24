using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.Areas.ViewComponents
{
    public class statistics2:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            Context c = new Context();
            ViewBag.writerCount = c.Writers.Count();



            return View();
        }
    }
}
