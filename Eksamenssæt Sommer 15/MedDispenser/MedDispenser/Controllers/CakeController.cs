﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedDispenser.Controllers
{
    public class CakeController : Controller
    {
        // GET: Cake
        public ActionResult Index()
        {
            return View();
        }
    }
}