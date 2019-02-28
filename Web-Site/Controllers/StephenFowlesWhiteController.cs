using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Site.Models;
using Web_Site.DataRepository;

namespace Web_Site.Controllers
{
    public class StephenFowlesWhiteController : Controller
    {
        //create a private  StephenFowlesWhiteRepos field that hold null
        private StephenFowles_White _stephenFowles_White = null;

        //create a construrtor that uses the private feild and 
        //assigns it a new set of data
        public StephenFowlesWhiteController()
            {
            _stephenFowles_White = new StephenFowles_White();
            }

        // GET: StephenFowlesWhite
        public ActionResult Index()
        {
            //get the data using the get data method

            var StephenFowlesWhiteView = _stephenFowles_White.GetStephensData();

            // retunr the assigned varable data to the view
            return View(StephenFowlesWhiteView);
        }
    }
}