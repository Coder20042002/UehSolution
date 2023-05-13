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
    public class LichSuConfiuration : IEntityTypeConfiguration<Lichsu>
    {
        public void Configure(EntityTypeBuilder<Lichsu> builder)
        {
            builder.ToTable("Lichsus");
            builder.HasKey(x => x.MaDk);
            builder.Property(x => x.NoiDung).IsRequired();

            builder.HasOne(ls => ls.Dangkycuoi)
                .WithMany(dk => dk.lichsus)
                .HasForeignKey(ls => ls.MaDk)
                .HasConstraintName("FK_LíchU_DangKy");


        }
    }
}
