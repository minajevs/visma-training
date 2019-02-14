using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace simple_razor_demo.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public string Name { get; set; }

        public void OnGet()
        {
            Name = "Dmitrijs";

            Message = "Your application description page.";
        }
    }
}
