using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VittighederWeb.Controllers
{
    public class MyJokesController : Controller
    {
        // GET: MyJokes
        public ActionResult Index()
        {
            return View();
        }
    }
}