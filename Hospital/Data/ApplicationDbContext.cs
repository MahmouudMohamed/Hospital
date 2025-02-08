using Hospital.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Numerics;

namespace Hospital.Data
{
    public class ApplicationDbContext : DbContext
    {
            public DbSet<Doctor> Doctors { get; set; }
            public DbSet<CompleteAppointment> CompleteAppointments { get; set; }
        public object CompleteAppointment { get; internal set; }

        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);

                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=hospitalDatabase;Integrated Security=True;TrustServerCertificate=True");
            }

        }
    }

