using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcdemo.Models.adonet
{
    public class Category
    {
        [MinLength(2,ErrorMessage = "Minimum Length is 2")]
        [Required(ErrorMessage = "Category code is missing!")]
        public string Code { get; set; }

        [MinLength(5, ErrorMessage = "Minimum Length is 5")]
        [Required(ErrorMessage = "Category description is missing!")]
        public string Description  { get; set; }
    }
}