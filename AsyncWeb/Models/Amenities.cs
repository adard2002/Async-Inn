using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWeb.Models
{
    public class Amenities
    {


        public int Id { get; set; }


        [Required]
        [StringLength(1000)]
        public string Name { get; set; }

    }
}
