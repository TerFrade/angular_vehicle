using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vehicle_Registration_Backend.Models;

namespace Vehicle_Registration_Backend.Models
{
    public class VehicleRegistrationContext : DbContext
    {
        public VehicleRegistrationContext (DbContextOptions<VehicleRegistrationContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle_Registration_Backend.Models.Model> Model { get; set; }

        public DbSet<Vehicle_Registration_Backend.Models.Make> Make { get; set; }
    }
}
