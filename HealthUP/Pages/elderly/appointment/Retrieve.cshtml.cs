using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthUP.Models;
using HealthUP.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HealthUP.Pages.elderly.appointment
{
    public class RetrieveModel : PageModel
    {
        [BindProperty]
        public Appointment MyAppointment { get; set; }


        private readonly AppointmentService _svc;
        public RetrieveModel(AppointmentService service)
        {
            _svc = service;
        }

        public IActionResult OnGet(string id)
        {
            if (id != null)
            {
                MyAppointment = _svc.GetAppointmentById(id);
                return Page();
            }
            else
                return RedirectToPage("Index");
        }
        //public IActionResult OnPost()
        //{
        //}
    }
}
