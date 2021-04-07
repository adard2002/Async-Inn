using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWeb.Models
{
    public class RoomAmenities
    {


        [Required]
        [StringLength(1000)]
        public string Amenities { get; set; }


        [Required]
        [StringLength(100)]
        public string Room { get; set; }


    }
}
