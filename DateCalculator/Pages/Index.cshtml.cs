using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DateCalculator.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public int DurationInDays { get; set; }
        [BindProperty]
        public DateTime StartDate { get; set; }
        public String  CompletionDate { get; set; }

        public bool DataSubmitted = false;

    

        public IndexModel()
        {
          DateTime ts = DateTime.Now;
            StartDate =  new DateTime(ts.Year, ts.Month, ts.Day, 0, 0, 0);
            DurationInDays = 4;
        }
        public void OnPost()
        {
                DataSubmitted = true;
                CompletionDate = StartDate.AddDays(DurationInDays).Date.ToString();       
        }


    }
}
