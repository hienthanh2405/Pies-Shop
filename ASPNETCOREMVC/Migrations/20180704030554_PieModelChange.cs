using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNETCOREMVC.Migrations
{
    public partial class PieModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isInStock",
                table: "Pies",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isInStock",
                table: "Pies");
        }
    }
}
