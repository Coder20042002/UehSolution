using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ueh.Data.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dots",
                columns: table => new
                {
                    maDot = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenDot = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    starDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dots", x => x.maDot);
                });

            migrationBuilder.CreateTable(
                name: "Khoas",
                columns: table => new
                {
                    makhoa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenkhoa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoas", x => x.makhoa);
                });

            migrationBuilder.CreateTable(
                name: "Loais",
                columns: table => new
                {
                    maloai = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenloaij = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loais", x => x.maloai);
                });

            migrationBuilder.CreateTable(
                name: "Giangviens",
                columns: table => new
                {
                    magv = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tengv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    makhoa = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giangviens", x => x.magv);
                    table.ForeignKey(
                        name: "FK_GangVien_Khoa",
                        column: x => x.makhoa,
                        principalTable: "Khoas",
                        principalColumn: "makhoa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    mssv = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    className = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    faculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    classStudentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthplace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studyStatusId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Khoamakhoa = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.mssv);
                    table.ForeignKey(
                        name: "FK_Students_Khoas_Khoamakhoa",
                        column: x => x.Khoamakhoa,
                        principalTable: "Khoas",
                        principalColumn: "makhoa");
                });

            migrationBuilder.CreateTable(
                name: "Dangkytruocs",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    mssv = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    magv = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    madot = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    maloai = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dangkytruocs", x => x.id);
                    table.ForeignKey(
                        name: "FK_DangKyTruoc_Dot",
                        column: x => x.madot,
                        principalTable: "Dots",
                        principalColumn: "maDot",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DangKyTruoc_GiangVien",
                        column: x => x.magv,
                        principalTable: "Giangviens",
                        principalColumn: "magv",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DangKyTruoc_Loai",
                        column: x => x.maloai,
                        principalTable: "Loais",
                        principalColumn: "maloai",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DangKyTruoc_Student",
                        column: x => x.mssv,
                        principalTable: "Students",
                        principalColumn: "mssv",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dangkytruocs_madot",
                table: "Dangkytruocs",
                column: "madot");

            migrationBuilder.CreateIndex(
                name: "IX_Dangkytruocs_magv",
                table: "Dangkytruocs",
                column: "magv");

            migrationBuilder.CreateIndex(
                name: "IX_Dangkytruocs_maloai",
                table: "Dangkytruocs",
                column: "maloai");

            migrationBuilder.CreateIndex(
                name: "IX_Dangkytruocs_mssv",
                table: "Dangkytruocs",
                column: "mssv");

            migrationBuilder.CreateIndex(
                name: "IX_Giangviens_makhoa",
                table: "Giangviens",
                column: "makhoa");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Khoamakhoa",
                table: "Students",
                column: "Khoamakhoa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dangkytruocs");

            migrationBuilder.DropTable(
                name: "Dots");

            migrationBuilder.DropTable(
                name: "Giangviens");

            migrationBuilder.DropTable(
                name: "Loais");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Khoas");
        }
    }
}
