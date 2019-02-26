using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Site.Models;

namespace Web_Site.Models
{
    public class ProgLang
    {
        public string Language { get; set; }

        public string[] Frameworks { get; set; }

        public string DescriptionLang { get; set; }
    }
}