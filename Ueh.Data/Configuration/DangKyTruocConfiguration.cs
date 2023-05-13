using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ueh.Data.Entities;

namespace Ueh.Data.Configuration
{
    public class DangKyTruocConfiguration : IEntityTypeConfiguration<Dangkytruoc>
    {
        public void Configure(EntityTypeBuilder<Dangkytruoc> builder)
        {
            builder.ToTable("Dangkytruocs");
            builder.HasKey(x => x.id);

            builder.HasOne(x => x.Giangvien)
                   .WithMany(x => x.dangkytruocs)
                   .HasForeignKey(x => x.magv)
                   .HasConstraintName("FK_DangKyTruoc_GiangVien");


            builder.HasOne(dkt => dkt.Student)
                   .WithMany(s => s.dangkytruoc)
                   .HasForeignKey(dkt => dkt.mssv)
                   .HasConstraintName("FK_DangKyTruoc_Student");

            builder.HasOne(x => x.Dot)
                   .WithMany(x => x.dangkytruocsList)
                   .HasForeignKey(x => x.madot)
                   .HasConstraintName("FK_DangKyTruoc_Dot");


            builder.HasOne(x => x.Loai)
                   .WithMany(x => x.dangkytruocs)
                   .HasForeignKey(x => x.maloai)
                   .HasConstraintName("FK_DangKyTruoc_Loai");




        }
    }
}
