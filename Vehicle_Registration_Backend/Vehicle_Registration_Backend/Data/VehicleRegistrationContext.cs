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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserVehicle>().HasKey(uv =>
              new { uv.UserId, uv.VehicleId });
        }
        public DbSet<Vehicle_Registration_Backend.Models.Make> Make { get; set; }

        public DbSet<Vehicle_Registration_Backend.Models.Feature> Feature { get; set; }

        public DbSet<Vehicle_Registration_Backend.Models.User> User { get; set; }

        public DbSet<Vehicle_Registration_Backend.Models.Vehicle> Vehicle { get; set; }

       }
}
