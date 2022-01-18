using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthUP.Models
{
    public class MedicalReport
    {
        [Required]
        [Key]
        public string Report_id { get; set; }
        [Required]
        public DateTime Report_date { get; set; }
        [Required]
        public bool Signature { get; set; }
        [Required]
        public long Symptoms { get; set; }
        [Required]
        public long Immunities { get; set; }
        [Required]
        public long Medicines { get; set; }
        [Required]
        public double Medicine_cost { get; set; }
        public long Note { get; set; }
        [Required]
        public string DoctorNRIC { get; set; }
        [Required]
        public string ElderlyNRIC { get; set; }

    }
}
