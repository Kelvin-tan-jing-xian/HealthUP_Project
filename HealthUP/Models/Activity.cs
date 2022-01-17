using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthUP.Models
{
    public class Activity
    {
        [Required]
        public string Id { get; set; }

        [Required, MaxLength(25)]
        public string activity_name { get; set; }

        [Required]
        public string activity_description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime activity_start_date { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime activity_end_date { get; set; }

        [Required]
        public string activity_price { get; set; }
        [Required]
        public double activity_photo { get; set; }

    }
}
