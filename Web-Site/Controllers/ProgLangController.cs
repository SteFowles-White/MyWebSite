using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Site.Models;

namespace Web_Site.Controllers
{
    public class ProgLangController : Controller
    {
        // GET: Need to review type of return https://www.tutorialsteacher.com/mvc/action-method-in-mvc
        public ActionResult ProgLang()
        {

            //instanate progLang model object
            var ProgLang = new ProgLang()
            {
                //put in the property values into the new ProgLang model class to 
                //set the data in the properties

                Language = "HTML & CSS",
                Frameworks = new string[]
                       { "BootStap,",
                          "W3.CSS",
                       },
                DescriptionLang = "Let hope this works"


        };

            return View(ProgLang);
        }

    }
}