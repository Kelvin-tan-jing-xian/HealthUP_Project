using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthUP.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthUP.Services
{
    public class AppointmentService
    {
        private Models.HealthUPDbContext _context;
        public AppointmentService(Models.HealthUPDbContext context)
        {
            _context = context;
        }


        public bool AddAppointment(Appointment newappointment)
        {
            if (AppointmentExists(newappointment.Id))
            {
                return false;
            }
            _context.Add(newappointment);
            _context.SaveChanges();
            return true;
        }
        private bool AppointmentExists(string id)
        {
            return _context.Appointments.Any(e => e.Id == id);
        }


    }
}
