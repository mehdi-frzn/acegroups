using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EF;

namespace them.Areas.dashboard.Controllers
{
    public class GalleryController : Controller
    {
        // GET: dashboard/Gallery
        public ActionResult Index()
        {
                    
            return View(model:SliderImages.selectimage());
        }
        public ActionResult Add()
        {

            return View();
        }
    }
}