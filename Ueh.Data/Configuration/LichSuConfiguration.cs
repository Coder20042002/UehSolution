using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Ueh.Data.Entities;

namespace Ueh.Data.Configuration
{
    public class LichSuConfiguration : IEntityTypeConfiguration<Lichsu>
    {
        public void Configure(EntityTypeBuilder<Lichsu> builder)
        {
            builder.ToTable("Lichsus");
            builder.HasKey(ls => ls.Id);
            builder.Property(ls => ls.NoiDung).IsRequired();






        }
    }
}
