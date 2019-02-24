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
            var HTML = new ProgLang()
            {
                Languague = "HTML & CSS",
                Frameworks = "HTML5, W3.CSS, BootStrap",
                Description = "Expereince with using Customer Made Front End Webpages and ulitising framworks such as W3.CC and Bootstap. All to ensure"
                               + "Your wesbite reaches the right people in the right way",
            };
            return View(HTML);
        }
    }
}