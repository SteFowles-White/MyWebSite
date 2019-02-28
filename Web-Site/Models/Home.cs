using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Site.Models
{
    public class Home
    {
        public string Title { get; set; }

        public string TextHeading { get; set; }

        public string imgIcon
        {
            get
            {
                return Title.Replace(" ", "_") + ".jpg";
            }
        }

    }
}