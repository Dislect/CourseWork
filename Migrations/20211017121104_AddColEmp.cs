using Microsoft.EntityFrameworkCore.Migrations;

namespace сoursework.Migrations
{
    public partial class AddColEmp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_positions_Positionid",
                table: "employees");

            migrationBuilder.RenameColumn(
                name: "Positionid",
                table: "employees",
                newName: "idPositionid");

            migrationBuilder.RenameIndex(
                name: "IX_employees_Positionid",
                table: "employees",
                newName: "IX_employees_idPositionid");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_positions_idPositionid",
                table: "employees",
                column: "idPositionid",
                principalTable: "positions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_positions_idPositionid",
                table: "employees");

            migrationBuilder.RenameColumn(
                name: "idPositionid",
                table: "employees",
                newName: "Positionid");

            migrationBuilder.RenameIndex(
                name: "IX_employees_idPositionid",
                table: "employees",
                newName: "IX_employees_Positionid");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_positions_Positionid",
                table: "employees",
                column: "Positionid",
                principalTable: "positions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
