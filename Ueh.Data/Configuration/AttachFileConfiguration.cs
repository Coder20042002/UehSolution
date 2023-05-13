using Email.UEH;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ueh.Data.Configuration
{
    public class AttachFileConfiguration : IEntityTypeConfiguration<AttachFile>
    {
        public void Configure(EntityTypeBuilder<AttachFile> builder)
        {
            builder.ToTable("AttachFiles");
            builder.HasKey(x => x.FileName);
            builder.HasOne(x => x.FileName);
        }
    }
}
