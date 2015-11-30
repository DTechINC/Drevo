using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webDrevo.Models;

namespace webDrevo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            EFTreesRepository rp = new EFTreesRepository();
            return View(rp.GetFolders());
        }

        protected override void Dispose(bool disposing)
        {            
            base.Dispose(disposing);
        }
    }
}