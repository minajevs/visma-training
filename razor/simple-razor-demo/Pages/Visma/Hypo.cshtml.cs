using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace simple_razor_demo.Pages.Visma
{
    public class Calculation
    {
        public int A { get; set; }
        public int B { get; set; }
        public string Result { get; set; }
    }

    public class HypoModel : PageModel
    {
        [BindProperty]
        public List<Calculation> History {
            get;
            set; }
        [BindProperty]
        public int A { get; set; }
        [BindProperty]
        public int B { get; set; } 

        public string Result { get; set; }

        public void OnGet()
        {
            if (History == null)
                History = new List<Calculation>();
        }

        public void OnPost()
        {
            try
            {
                if (A < 0)
                    throw new Exception("A should be positive");

                if (B < 0)
                    throw new Exception("B should be positive");

                var C = Math.Sqrt(A * A + B * B);

                if (double.IsNaN(C))
                {
                    throw new Exception("Can't calculate C!");
                }

                Result = $"C = {C}";
            }
            catch (Exception e)
            {
                Result = e.Message;
            }
            finally
            {
                History.Add(new Calculation { A = A, B = B, Result = Result });
            }
        }
    }
}