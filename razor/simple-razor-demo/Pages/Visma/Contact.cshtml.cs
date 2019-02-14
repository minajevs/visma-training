using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace simple_razor_demo.Pages.Visma
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Email { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            Message = $"{Name} will be contacted using {Email} email";
        }
    }
}