using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ueh.Data.Configuration;

namespace Ueh.Data.EF
{
    public class UEH_DbContext : DbContext
    {
        public UEH_DbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new EmailInfoConfiguration());

            //modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<RSStudent> Students { get; set; }
        public DbSet<EmailInfo> EmailInfos { get; set; }

    }
}
