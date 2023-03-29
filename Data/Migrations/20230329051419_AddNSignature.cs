using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCause.Data.Migrations
{
    public partial class AddNSignature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NSignature",
                table: "Petitions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NSignature",
                table: "Petitions");
        }
    }
}
