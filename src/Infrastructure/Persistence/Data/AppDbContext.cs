using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Registration> Registrations { get; set; }
        public DbSet<RegistrationInfo> RegistrationInfos { get; set; }
        public DbSet<MedicalWorker> MedicalWorkers { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CallResult> CallResults { get; set; }
    }
}
