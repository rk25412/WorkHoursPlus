using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkHourPlus.Migrations
{
    /// <inheritdoc />
    public partial class AddedManagerColumnInEmployeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Shifts_EmployeeId",
                table: "Shifts");

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "Employees",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_EmployeeId",
                table: "Shifts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ManagerId",
                table: "Employees",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ManagerId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Shifts_EmployeeId",
                table: "Shifts");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ManagerId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_EmployeeId",
                table: "Shifts",
                column: "EmployeeId",
                unique: true);
        }
    }
}
