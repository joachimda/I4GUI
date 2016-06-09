using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using json;
using SampleProjectAspNetMvc.Models;

namespace SampleProjectAspNetMvc.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        public ActionResult Index()
        {
            return View();
        }


        // POST: Jobs/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {

                //Using Json and user object
                UserInfo user = new UserInfo
                {
                    Experience = Request["aExperience"],
                    MailAddress = collection["aEmail"],
                    Name = collection["aName"]
                };

               
                Json json = new Json();

                List<UserInfo> users = new List<UserInfo>();
                users.Add(user);

                //Serialize object for other use
                json.Serialize(users);

                return View("Confirmation");
            }
            catch
            {
                return View("Error");
            }

            /*Standard method using System.IO*/
                //    var name = collection["aName"];
                //    var email = collection["aEmail"];
                //    var experience = Request["aExperience"];
                //    var userData = "Name:" + name + ", E-Mail: " + email + ", Experience:" + experience +
                //                   Environment.NewLine;

                //    var file = Server.MapPath("~/App_Data/data.txt");
                //    System.IO.File.AppendAllText(@file,userData);

                //    return View("Confirmation");
                //}
                //catch
                //{
                //    return View("Error");
                //}
            }

    }
}
