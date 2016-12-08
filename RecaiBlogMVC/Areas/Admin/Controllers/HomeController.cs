using RecaiBlogMVC.Areas.Admin.Models.Attributes;
using RecaiBlogMVC.Models.ORM.Context;
using RecaiBlogMVC.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecaiBlogMVC.Areas.Admin.Controllers
{
    [LoginControl]//user giriş yapmışsa
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {

            //BlogContext db = new BlogContext();

            //string email = HttpContext.User.Identity.Name;

            //AdminUser user = db.AdminUsers.FirstOrDefault(x => x.Email == email);

            //string name = user.Name;
            //string surname = user.SurName;

            return View();
        }
    }
}