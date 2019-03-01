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
        private static DecriptionData[] _mainPageData = new DecriptionData[]
        {
             new DecriptionData()
                {
                    Title = "C# ASP.Net MVC Developer",
                    Name = "Stephen Fowles-White",
                    Header = "I am not a developer.... not yet anyway. I am an IT recruiter " +
                             "looking to change careers into to one of the most rewarding job roles - a developer. " +
                             "For the past year I have developed my coding skills whilst also having a great " +
                             "ability to build long lasting relationship with clients and stakholder. I am am expereince " +
                             "in C# and vanillia Javascript OOP principles and developing solid fully rounded website."
                  }
        };



    //create a private static array with the inside
    //This need to use the StephenFowlesWhite Model
    //Populate the data

    //create a public method call Get.......data name
    //it returns the private static data array

            public DecriptionData[] GetDecriptionData()
            {
                var TabData = _mainPageData;
                return TabData;

            }
    }
}