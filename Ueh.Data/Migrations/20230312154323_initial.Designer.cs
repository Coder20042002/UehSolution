﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ueh.Data.EF;

#nullable disable

namespace Ueh.Data.Migrations
{
    [DbContext(typeof(UEH_DbContext))]
    [Migration("20230312154323_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ueh.Data.EF.EmailInfo", b =>
                {
                    b.Property<string>("Bcc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsBodyHtml")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("EmailInfos", (string)null);
                });

            modelBuilder.Entity("Ueh.Data.EF.RSStudent", b =>
                {
                    b.Property<string>("mssv")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("birthday")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("birthplace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("classtudentname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cmnd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hoten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("khoa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("studystastuid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("mssv");

                    b.ToTable("RSStudents", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
