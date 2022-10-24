using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_BlogPR.ViewComponents
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager cm = new CommentManager(new efCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetLista(id);
            return View(values);
        }
    }
}
