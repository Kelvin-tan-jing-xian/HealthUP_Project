using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HealthUP.Models;
using HealthUP.Services;
using Microsoft.Extensions.Logging;

namespace HealthUP.Pages.doctor.report
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        private ReportService _svc;
        public CreateModel(ILogger<CreateModel> logger, ReportService service)
        {
            _logger = logger;
            _svc = service;
        }
        [BindProperty]
        public MedicalReport report { get; set; }
        public string MyMessage { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {

            if (ModelState.IsValid)
            {
                if (_svc.AddReport(report))
                {
                    return RedirectToPage("success");
                }
                else
                {
                    MyMessage = "Report already exitsi";
                    return Page();
                }
            }
            return Page();
        }

    }
}