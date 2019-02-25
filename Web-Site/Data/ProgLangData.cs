using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Site.Models;

namespace Web_Site.Data
{
    public class ProgLangData
    {
        private static ProgLang[] _progLang = new ProgLang[]
        {
            new ProgLang()

                {
                    Languague = "HTML & CSS",
                    Frameworks = "HTML5, W3.CSS, BootStrap",
                    Description = "Expereince with using Customer Made Front End Webpages and ulitising framworks such as W3.CC and Bootstap. All to ensure"
                           + "Your wesbite reaches the right people in the right way",
                },
             new ProgLang()
             {
                    Languague = "JavaScript",
                    Frameworks = "DOM,Ajax, Vanillia JavaScript, ES6",
                    Description = "Expereinced using Javascript for front end utilisation and ensure Websites are interactive. " +
                                  "Building from the ground up to ensure that it meed the website needs",
              },
              new ProgLang()
              {
                    Languague = "C#",
                    Frameworks = "ASP.net MVC",
                    Description = "Developing fully funtions websites to ensure that front end platforms enable fully dynamic websites",
               },


        };
    }
}