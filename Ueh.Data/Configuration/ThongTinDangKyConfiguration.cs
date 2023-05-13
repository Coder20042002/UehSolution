//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Ueh.Data.Entities;

//namespace Ueh.Data.Configuration
//{
//    public class ThongTinDangKyConfiguration : IEntityTypeConfiguration<Thongtindangky>
//    {
//        public void Configure(EntityTypeBuilder<Thongtindangky> builder)
//        {
//            builder.ToTable("Thongtindangkys");
//            builder.HasKey(x => new { x.madk, x.masv });

//            builder.HasOne(x => x.dangkycuoi)
//                .WithMany(x => x.thongtindangky)
//                .HasForeignKey(x => x.masv)
//                .HasConstraintName("FK_ThongTinDangKy_Student");

//            builder.HasOne(x => x.student)
//                .WithMany(x => x.thongtindangkies)
//                .HasForeignKey(x => x.masv)
//                .HasConstraintName("FK_ThongTinDangKy_Student");


//        }
//    }
//}
