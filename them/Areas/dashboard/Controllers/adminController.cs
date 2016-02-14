using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF;

namespace them.Areas.dashboard.Controllers
{
   [Authorize]
    public class adminController : Controller
    {
        
        // GET: dashboard/admin
        public ActionResult Index()
        {
            return View();
            
        }
        public ActionResult select()
        {
            return View(model:SliderImages.selectimage());
        }
       [HttpGet]
        public ActionResult Addimage()
        {
            return View();
        }
       [HttpPost]
       public ActionResult Addimage(string title, string imagepath, string status)
        {
            var images = Request.Files[0];
            if (images.ContentType == "image/jpeg")
            {
                string path = "~/images/slider/" + DateTime.Now.Millisecond.ToString() +images.FileName;
                images.SaveAs(Server.MapPath(path));
                SliderImage slider = new SliderImage();
                slider.Title = title;
                slider.ImagePath = path;
                slider.Status = ((string.IsNullOrEmpty(status))? false : true);
                SliderImages.Addimages(slider);
                return View("index");
            }
            else 
            { 
                return View(model:"عکس غیر مجاز است"); 
            }
            
        }
       [HttpGet]
       public ActionResult edit(int id)
       {
           return View(SliderImages.selectsingle(id));
       }
       [HttpPost]
       public ActionResult edit(int ID,string title,string imagepath,string status,string path)
       { 
           SliderImage slider = new SliderImage();
           var images = Request.Files[0];
           if (string.IsNullOrEmpty(images.FileName))
           {
               slider.ID = ID;
               slider.Title = title;
               slider.ImagePath = path;
               slider.Status = (string.IsNullOrEmpty(status) ? false : true);
               SliderImages.updateimage(slider);
               return View("index");
           }
           else if (images.ContentType == "image/jpeg")
           {
               string pathh = "~/images/slider/" + DateTime.Now.Millisecond.ToString() + images.FileName;
               images.SaveAs(Server.MapPath(pathh));
               slider.ID = ID;
               slider.Title = title;
               slider.ImagePath = pathh;
               slider.Status = ((string.IsNullOrEmpty(status)) ? false : true);
               SliderImages.updateimage(slider);
               return View("index");
           }
           else
               return View(model:"عکس غیر مجاز است");

       }
       public ActionResult delete(int id)
       {
           SliderImages.delete(id);
           return RedirectToAction("index");
       }
    }
}