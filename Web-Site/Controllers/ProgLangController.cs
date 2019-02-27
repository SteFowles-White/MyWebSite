using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Site.DataRepository;

namespace Web_Site.Controllers
{
    public class ProgLangController : Controller
    {
        //create a provate variable to return but currently returns null
        private ProgramLangRepository _programLangRepository = null;

        //create a constructor class - this is called when an instance of the class is instantiated
        public ProgLangController()
            {
                //instanate the ProgramLangRepository class from the DataRepository
                _programLangRepository = new ProgramLangRepository();

            }


        // This is the set up Action Result
        public ActionResult Index()
        {
            var ProglangViewData = _programLangRepository.GetProgLangs();
            return View(ProglangViewData);
        }





        
        //This Action REsult might not be needed


        // when you use the ? in a class paramter it means the return can be null
        public ActionResult ProgLang(int? id)
        {
            //need to check if null otherwise the page wont render
            if(id == null)
                {
                return HttpNotFound();
                }

            //call the GetProgLang method in the ProgramLangRepository class
            //Assign this to var

            var ProgLang = _programLangRepository.GetProgLang(id.Value);



            return View(ProgLang);
        }

    }
}