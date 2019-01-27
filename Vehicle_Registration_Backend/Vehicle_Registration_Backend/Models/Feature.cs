using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Registration_Backend.Models
{
    public class Feature
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
