using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartmentApp.Migrations
{
    public partial class relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentid",
                table: "employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_departmentid",
                table: "employees",
                column: "departmentid");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_departmentid",
                table: "employees",
                column: "departmentid",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_departmentid",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_departmentid",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "departmentid",
                table: "employees");
        }
    }
}
