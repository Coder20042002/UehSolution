﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ueh.Data.Entities;

namespace Ueh.Data.Configuration
{
    public class GiangVienConfiguration : IEntityTypeConfiguration<Giangvien>
    {
        public void Configure(EntityTypeBuilder<Giangvien> builder)
        {
            builder.ToTable("Giangviens");
            builder.HasKey(x => x.magv);
            builder.HasOne(x => x.khoa)
                .WithMany(x => x.giangviens)
                .HasForeignKey(x => x.makhoa)
                .HasConstraintName("FK_GangVien_Khoa");
        }
    }
}
