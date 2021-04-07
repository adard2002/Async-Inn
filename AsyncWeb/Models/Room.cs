using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncWeb.Models
{
    public class Room
    {



        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }


        [Required]
        [Range(0,2)]
        public int Layout { get; set; }




    }
}
