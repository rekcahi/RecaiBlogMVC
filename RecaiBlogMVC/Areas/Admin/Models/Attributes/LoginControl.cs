using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecaiBlogMVC.Areas.Admin.Models.Attributes
{
    //Giriş Kontrolü için Kullanılacak kullanıcı doğrulanmamışsa login e yönlendir
    public class LoginControl:ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
                filterContext.HttpContext.Response.Redirect("/Admin/Login/ındex");
        }
    }
}