using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core_BlogPR.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]     
        public async Task<IActionResult> Index(Writer p,Admin a)
        {
                                             // session
                                             
            Context c = new Context();
            var kullanici = c.Writers.Where(x => x.mail == p.mail).FirstOrDefault();
          
            
            var datavalue = c.Writers.FirstOrDefault(x => x.mail == p.mail && x.password == p.password);
            var datavalueAdmin = c.Admins.FirstOrDefault(x => x.mail == a.mail && x.password == a.password);
            if (datavalue != null)
            {
                var claims = new List<Claim>
               {
                
                new Claim(ClaimTypes.Email, p.mail),
                new Claim(ClaimTypes.Name, kullanici.writerName),
                new Claim(ClaimTypes.Surname, kullanici.writerAbout),
                new Claim(ClaimTypes.GivenName, kullanici.writerImage),
                new Claim(ClaimTypes.Role, kullanici.writerID.ToString())
                
                
               };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                 ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);
                
                return RedirectToAction("BlogListByWriter", "Writer");

            }
            else if (datavalueAdmin != null)
            {
                var Admin = c.Admins.Where(x => x.mail == a.mail).FirstOrDefault();
                 var claimsAdmin = new List<Claim>
                  {

                new Claim(ClaimTypes.Role, Admin.role),
                new Claim(ClaimTypes.Name, Admin.name),
                new Claim(ClaimTypes.Surname, a.mail),
                new Claim(ClaimTypes.GivenName, Admin.image),
                new Claim(ClaimTypes.NameIdentifier, Admin.adminID.ToString())


                  };
                var identity = new ClaimsIdentity(claimsAdmin, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "Widgets", new { area = "Admin" });
            }
            else
            {
                ViewBag.girisHata = "Kullanıcı adı veya şifre yanlış";
                return View();
            }
           
        }
        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Blog");
        }
    }
}
