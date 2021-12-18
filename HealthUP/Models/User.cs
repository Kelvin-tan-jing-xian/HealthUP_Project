using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthUP.Models
{
    public class User
    {

        [Required]
        public string NRIC { get; set; }

        [Required, MaxLength(25)]
        public string Fname { get; set; }
        [Required, MaxLength(25)]
        public string Lname { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [Required, MaxLength(30)]
        public string Password { get; set; }

        [Required]
        public string Gender { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public string StreetAddress { get; set; }
        [Required]
        public int PostalCode { get; set; }
        [Required]
        public string UnitNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public string Specialisation { get; set; }
        public string HospitalAddress { get; set; }


    }
}
