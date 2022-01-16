using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthUP.Models;
using HealthUP.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HealthUP.Pages.elderly.appointments
{
    public class ThankYouModel : PageModel
    {
        [BindProperty]
        public List<Appointment> allappointments { get; set; }

        private readonly ILogger<ThankYouModel> _logger;
        private AppointmentService _svc;
        public ThankYouModel(ILogger<ThankYouModel> logger, AppointmentService service)
        {
            _logger = logger;
            _svc = service;
        }

        public void OnGet()
        {
            allappointments = _svc.GetAllAppointments();

        }
        //public IActionResult OnPost()
        //{


        //}
    
    }
}
