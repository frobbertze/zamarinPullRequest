using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace XamarinTestData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int id)
        {
         
            id = id + 1;
            return Json(id, JsonRequestBehavior.AllowGet);
        }
      
    }
}