using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace simple_razor_demo.Pages.Visma
{
    public class IndexModel : PageModel
    {
        public string[] Names { get; set; }

        public void OnGet()
        {
            Names = new[] { "Dmitrijs", "Jurijs", "Aleks" };
        }
    }
}