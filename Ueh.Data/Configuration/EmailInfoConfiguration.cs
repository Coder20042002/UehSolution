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

    public class EmailInfoConfiguration : IEntityTypeConfiguration<EmailInfo>
    {
        public void Configure(EntityTypeBuilder<EmailInfo> builder)
        {
            builder.ToTable("EmailInfos");
            builder.HasNoKey();
        }
    }

}
