using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueh.Data.EF
{
    public class UEH_DbContextFactory : IDesignTimeDbContextFactory<UEH_DbContext>
    {
        public UEH_DbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("UehDb");

            var optionsBuilder = new DbContextOptionsBuilder<UEH_DbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new UEH_DbContext(optionsBuilder.Options);
        }
    }
}
