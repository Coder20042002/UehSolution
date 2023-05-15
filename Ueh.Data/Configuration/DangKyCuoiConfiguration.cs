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
    public class DangKyCuoiConfiguration : IEntityTypeConfiguration<Dangkycuoi>
    {
        public void Configure(EntityTypeBuilder<Dangkycuoi> builder)
        {
            builder.ToTable("Dangkycuois");

            builder.HasKey(x => x.id);

            builder.HasOne(x => x.Giangvien)
                   .WithMany(x => x.dangkycuoi)
                   .HasForeignKey(x => x.magv)
                   .HasConstraintName("FK_DangKyCuoi_GiangVien");


            builder.HasOne(dkc => dkc.Student)
                   .WithMany(s => s.dangkycuoi)
                   .HasForeignKey(dkc => dkc.mssv)
                   .HasConstraintName("FK_DangKyCuoi_Student");


            builder.HasOne(x => x.Dot)
                   .WithMany(x => x.dangkycuoiList)
                   .HasForeignKey(x => x.madot)
                   .HasConstraintName("FK_DangKyCuoi_Dot");


            builder.HasOne(x => x.Loai)
                   .WithMany(x => x.dangkycuois)
                   .HasForeignKey(x => x.maloai)
                   .HasConstraintName("FK_DangKyCuoi_Loai");


            //builder.HasOne(x => x.thongtindangky)
            //       .WithOne(x => x.dangkycuoi)
            //       .HasForeignKey<Thongtindangky>(x => x.madk)
            //       .HasConstraintName("FK_DangKyCuoi_ThongTinDangKy");



        }
    }
}
