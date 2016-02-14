using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF;
using System.Web.Security;

namespace them.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        [HttpGet]
        public ActionResult index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string user,string pass,string remember)
        {
            if (users.Isvalid(user, pass) == true)
            {
                FormsAuthentication.SetAuthCookie(user, (remember == "on") ? false : true);
                return Redirect("/dashboard/admin/index");
            }
            else 
            { 
                return View(model:"نام کاربری یا رمز عبور نادرست است");
            }
        }
        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return View("index");
        }
    }
}