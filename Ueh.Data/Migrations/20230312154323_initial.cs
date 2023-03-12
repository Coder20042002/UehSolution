using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ueh.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailInfos",
                columns: table => new
                {
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bcc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsBodyHtml = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "RSStudents",
                columns: table => new
                {
                    mssv = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hoten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    khoa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cmnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    classtudentname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthday = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthplace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studystastuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HDT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSStudents", x => x.mssv);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailInfos");

            migrationBuilder.DropTable(
                name: "RSStudents");
        }
    }
}
