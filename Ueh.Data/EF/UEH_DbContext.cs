using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ueh.Data.Configuration;
using Ueh.Data.Entities;

namespace Ueh.Data.EF
{
    public class UEH_DbContext : DbContext
    {
        public UEH_DbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new DotConfiguration());
            modelBuilder.ApplyConfiguration(new GiangVienConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiConfiguration());
            modelBuilder.ApplyConfiguration(new KhoaConfiguration());
            modelBuilder.ApplyConfiguration(new DangKyTruocConfiguration());

            modelBuilder.ApplyConfiguration(new LichSuConfiguration());
            modelBuilder.ApplyConfiguration(new DangKyCuoiConfiguration());
            //modelBuilder.ApplyConfiguration(new ThongTinDangKyConfiguration());
            //modelBuilder.ApplyConfiguration(new EmailInfoConfiguration());


            //modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Dot> Dots { get; set; }
        public DbSet<Giangvien> Giangviens { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<Dangkytruoc> Dangkytruocs { get; set; }
        public DbSet<Dangkycuoi> Dangkycuois { get; set; }

        public DbSet<Lichsu> Lichsus { get; set; }

        //public DbSet<Thongtindangky> Thongtindangkies { get; set; }
        //public DbSet<EmailInfo> EmailInfos { get; set; }





    }
}
