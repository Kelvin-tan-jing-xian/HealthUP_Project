using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HealthUP.Models;

namespace HealthUP.Pages.admin
{
    public class ActivityModel : PageModel
    {
        [BindProperty]
        public Activity myactivity { get; set; }
        public void OnGet()
        {
        }
    }
}
