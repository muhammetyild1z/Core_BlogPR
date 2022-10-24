using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_BlogPR.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            string p = "admin@gmail.com";
            MessageManager mm = new MessageManager(new efMessageRepository());
            var values = mm.GetInboxListbyWriter(p);
            return View(values);
        }
    }
}
