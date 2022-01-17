using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthUP.Models;
using HealthUP.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace HealthUP.Pages.elderly.appointment
{
    public class EditModel : PageModel
    {
        private readonly ILogger<EditModel> _logger;
        private AppointmentService _svc;
        public EditModel(ILogger<EditModel> logger, AppointmentService service)
        {
            _logger = logger;
            _svc = service;
        }

        [BindProperty]
        public Appointment MyAppointment { get; set; }
        [BindProperty]
        public string MyMessage { get; set; }
        //public DateTime AvailableDate { get; set; }

        public void OnGet()
        {
        }
    }
}
