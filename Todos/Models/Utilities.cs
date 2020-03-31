using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Todos.Models
{
    public class Utilities
    {
        public static string GetCategoryName(string code)
        {
            switch(code)
            {
                case "ed": return "Education";
                case "en": return "Entertainment";
                case "fi": return "Finance";
                case "hh": return "Home";
                case "wo": return "Work";
                default:
                    return "Unknow";
            }
        }
    }
}