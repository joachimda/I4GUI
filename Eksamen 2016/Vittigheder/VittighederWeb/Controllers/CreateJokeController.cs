using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using VittighederWeb.Models;
using VittighederWeb.Tools;

namespace VittighederWeb.Controllers
{
    public class CreateJokeController : Controller
    {
        // GET: CreateJoke
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            JsonToolbox jsonToolbox = new JsonToolbox();
            List<Joke> jokes = new List<Joke>();

            jokes = jsonToolbox.DeSerialize();

            try
            {
                Joke joke = new Joke()
                {
                    Author = collection["author"],
                    Tags = collection["tags"],
                    DateTime = DateTime.Now,
                    Text = collection["jokeText"]
                };

                jokes.Add(joke);
                jsonToolbox.Serialize(jokes);

                return View("CreateSuccess");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }
    }
}