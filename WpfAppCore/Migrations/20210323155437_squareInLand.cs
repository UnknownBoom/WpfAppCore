using Microsoft.EntityFrameworkCore.Migrations;

namespace WpfAppCore.Migrations
{
    public partial class squareInLand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "square",
                table: "Lands",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "square",
                table: "Lands");
        }
    }
}
