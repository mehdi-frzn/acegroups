using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF;

namespace them.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string Name, string email, string website, string subject, string message)
        {
            contactu cmt = new contactu();
            cmt.name = Name;
            cmt.email = email;
            cmt.website = website;
            cmt.subject = subject;
            cmt.message = message;
            contactus.insertcontact(cmt);
            return View();
        }
    }
}