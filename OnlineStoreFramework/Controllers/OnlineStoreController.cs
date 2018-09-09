using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStoreFramework.Controllers
{
    public class OnlineStoreController : Controller
    {
        // GET: OnlineStore
        public ActionResult Index()
        {
            return View();
        }
    }
}