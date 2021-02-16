using Microsoft.EntityFrameworkCore.Migrations;

namespace ImpetusWebsite.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserMatchRelations",
                columns: table => new
                {
                    IdUser = table.Column<string>(nullable: false),
                    IdMatch = table.Column<string>(nullable: false),
                    Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMatchRelations", x => new { x.IdUser, x.IdMatch });
                    table.ForeignKey(
                        name: "FK_UserMatchRelations_Matchs_IdMatch",
                        column: x => x.IdMatch,
                        principalTable: "Matchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMatchRelations_AspNetUsers_IdUser",
                        column: x => x.IdUser,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserMatchRelations_IdMatch",
                table: "UserMatchRelations",
                column: "IdMatch");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserMatchRelations");
        }
    }
}
