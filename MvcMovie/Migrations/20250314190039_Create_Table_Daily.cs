using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMovie.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Daily : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Daily",
                columns: table => new
                {
                    MaHTPP = table.Column<string>(type: "TEXT", nullable: false),
                    Madaily = table.Column<string>(type: "TEXT", nullable: true),
                    Tendaily = table.Column<string>(type: "TEXT", nullable: true),
                    Diachi = table.Column<string>(type: "TEXT", nullable: true),
                    Nguoidaidien = table.Column<string>(type: "TEXT", nullable: true),
                    Dienthoai = table.Column<string>(type: "TEXT", nullable: true),
                    MaHTTP = table.Column<string>(type: "TEXT", nullable: true),
                    TenHTPP = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Daily", x => x.MaHTPP);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Daily");
        }
    }
}
