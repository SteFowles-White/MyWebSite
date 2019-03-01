using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Site.Models;

namespace Web_Site.DataRepository
{
    public class MainPageData
    {
        //1
        //create data that the StephenFowlesWhite Page will use
        private static TabData[] _mainPageData = new TabData[]
        {
            new TabData()
                {
                    Title = "",
                    Name = "",
                    Header = ""
                },
             new TabData()
                {
                    Title = "",
                    Name = "",
                    Header = ""
                },
             new TabData()
                {
                    Title = "",
                    Name = "",
                    Header = ""
                }
        };



    //create a private static array with the inside
    //This need to use the StephenFowlesWhite Model
    //Populate the data

    //create a public method call Get.......data name
    //it returns the private static data array

            public TabData[] GetTabData()
            {
                var TabData = _mainPageData;
                return TabData;

            }
    }
}