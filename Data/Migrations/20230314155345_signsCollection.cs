using Microsoft.EntityFrameworkCore.Migrations;

namespace TheCause.Data.Migrations
{
    public partial class signsCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SignCount",
                table: "Petitions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SignCount",
                table: "Petitions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
