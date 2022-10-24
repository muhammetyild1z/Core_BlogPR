using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.ViewComponents.Blog
{
    public class AddComment:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
