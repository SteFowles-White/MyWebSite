using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Site.Models;

namespace Web_Site.Models
{

    //Class that formats and set the data for the view (this is for the programing langauges
    public class ProgLang
    {
        public int Id { get; set; }

        public string Language { get; set; }

        public string[] Frameworks { get; set; }

        public string DescriptionLang { get; set; }
    }
}