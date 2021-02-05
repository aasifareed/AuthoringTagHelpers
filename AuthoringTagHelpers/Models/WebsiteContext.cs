using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthoringTagHelpers.Models
{
    public class WebsiteContext
    {

        [Required]
        public IEnumerable<string> CountryCodes { get; set; }

        [Required]
        public string Country { get; set;} 
    }
}
