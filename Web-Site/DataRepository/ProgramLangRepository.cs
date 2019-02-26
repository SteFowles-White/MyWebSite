using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_Site.Models;

namespace Web_Site.DataRepository
{
    //This holds programming langagues data
    public class ProgramLangRepository
    {

            //need to have serveral lists on Programming Lanagauges, create an array of data
            // need to create an array of ProgLang Models name _progLangData to set the data
            private static ProgLang[] _progLangData = new ProgLang[] 
            {
                //instanate progLang model object
                new ProgLang()
                        {
                    //put in the property values from the new ProgLang model class to 
                    //set the data in the properties
                            Id = 1,
                            Language = "HTML & CSS",
                            Frameworks = new string[]
                                   { "BootStap,",
                                     "W3.CSS",
                                   },
                            DescriptionLang = "Let hope this works"
                        },
                 new ProgLang()
                        {
                            Id = 2,
                            Language = "JavaScript",
                            Frameworks = new string[]
                                   { "Vanillia JavaScript,",
                                     "DOM",
                                     "JSON",
                                     "AJAX"
                                   },
                            DescriptionLang = "Let hope this works"
                        },
                  new ProgLang()
                        {
                            Id = 3,
                            Language = "C#",
                            Frameworks = new string[]
                                   { "ASP.NET MVC,"
                                   },
                            DescriptionLang = "Let hope this works"
                        },
                  new ProgLang()
                        {
                            Id = 4,
                            Language = "DataBase",
                            Frameworks = new string[]
                                   { "MYSQL"
                                   },
                            DescriptionLang = "Let hope this works"
                        },

             };

            //method that returns a ProgLang Model instance
            //public ProgLang (//this is the model instance) GetProgLang (name of method)
            public ProgLang GetProgLang(int id)
            {
                //need to have a method to return a value;
                ProgLang ProgLangReturn = null;

                    //loop through the _progLangData array
                    foreach (var languagues in _progLangData)
                    {

                            //acces the langauge in object Model with the same string as lang input

                            if (id == languagues.Id)
                            {
                                    //add return languagues to ProgLandReturn value
                                    ProgLangReturn = languagues;
                                    break;
                            }
                            else
                            {
                                    //add return null to ProgLandReturn value
                                    ProgLangReturn = null;

                            }
                    }
                   return ProgLangReturn;

            }
    }
}