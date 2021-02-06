using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartmentApp.Migrations
{
    public partial class removeclmn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detail",
                table: "departments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "detail",
                table: "departments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
