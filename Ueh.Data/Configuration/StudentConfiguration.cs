using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ueh.Data.EF;

namespace Ueh.Data.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<RSStudent>
    {
        public void Configure(EntityTypeBuilder<RSStudent> builder)
        {
            builder.ToTable("RSStudents");
            builder.HasKey(x => x.mssv);
            //builder.Property(x => x.email).IsRequired();
            //builder.Property(x => x.password).IsRequired();
            //builder.Property(x => x.email).IsRequired();


        }
    }
}
