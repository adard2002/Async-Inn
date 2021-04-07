using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWeb.Models
{
    public class Hotel
    {


        public int Id { get; set; }


        [Required]
        [StringLength(60)]
        public string Name { get; set; }


        [Required]
        [StringLength(150)]
        public string StreetAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(100)]
        public string Country { get; set; }

        [Required]
        [StringLength(15)]
        public string Phone { get; set; }









    }
}
