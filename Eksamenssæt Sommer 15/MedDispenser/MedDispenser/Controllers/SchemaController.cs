using System;
using System.Collections.Generic;
using System.Web.Mvc;
using MedDispenser.Models;

namespace MedDispenser.Controllers
{
    public class SchemaController : Controller
    {
        // GET: Schema
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Schema()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Json json = new Json();
            List<MedRule> rules = new List<MedRule>(); 

            try
            {
                MedRule rule = new MedRule
                {
                    Comment = collection["comment"],
                    MedicineType = collection["type"],
                    TimeToTake = collection["time"]
                };
                rules.Add(rule);
                
                json.Serialize(rules);

                return View("MedicineSubmit");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }

    }
}