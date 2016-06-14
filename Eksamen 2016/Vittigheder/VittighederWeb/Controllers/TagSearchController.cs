using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VittighederWeb.Controllers
{
    public class TagSearchController : Controller
    {
        // GET: TagSearch
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Search(string query)
        {
            ViewData["id"] = query;
            return View("Result");
        }
    }
}