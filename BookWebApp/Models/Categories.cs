using System;
using System.Linq;
using BookWebApp.Helpers; 

namespace BookWebApp.Models
{
    public class Categories
    {
        public static string[] Get {
            get {
                return new string[] { "Android", "Angular", "ASP.NET", "ASP.NET MVC", "C#", "CSS", "iOS", "Javascript", "jQuery", "Knockout.js", "LESS", "MySQL", "PHP", "React", "SASS", "Swift", "Wordpress" }; 
            }

        }

        public static string FindOne(string slug){
           return Get.FirstOrDefault(x => x.Slug() == slug); 
        }
    }
}



