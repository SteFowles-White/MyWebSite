using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Site.Models;

namespace Web_Site.DataRepository
{

    //set up data that wil be used on the Home Page
    public class HomeRepository
    {
        private static Home[] _homes = new Home[]
        {
            new Home()
                {
                    Title = "",
                    TextHeading = ""
                 },
            new Home()
                {
                    Title = "",
                    TextHeading = ""
                 },
            new Home()
                {
                    Title = "",
                    TextHeading = ""
                 }

        };

    }
}