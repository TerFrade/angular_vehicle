using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicle_Registration_Backend.Models
{
    public class User
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string ContactName { get; set; }
        [Required]
        [StringLength(255)]
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public DateTime LastUpdate { get; set; }

        public ICollection<UserVehicle> UserVehicles { get; set; }

        public User()
        {
            UserVehicles = new Collection<UserVehicle>();
        }
    }
}
