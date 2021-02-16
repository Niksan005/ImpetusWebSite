using Microsoft.EntityFrameworkCore.Migrations;

namespace ImpetusWebsite.Migrations
{
    public partial class _2000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ponts",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ponts",
                table: "AspNetUsers");
        }
    }
}
