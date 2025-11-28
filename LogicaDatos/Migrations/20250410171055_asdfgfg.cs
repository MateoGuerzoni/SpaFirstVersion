using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogicaDatos.Migrations
{
    /// <inheritdoc />
    public partial class asdfgfg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpleadoTurnoServicios_Reservas_ReservaId",
                table: "EmpleadoTurnoServicios");

            migrationBuilder.AlterColumn<int>(
                name: "ReservaId",
                table: "EmpleadoTurnoServicios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpleadoTurnoServicios_Reservas_ReservaId",
                table: "EmpleadoTurnoServicios",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpleadoTurnoServicios_Reservas_ReservaId",
                table: "EmpleadoTurnoServicios");

            migrationBuilder.AlterColumn<int>(
                name: "ReservaId",
                table: "EmpleadoTurnoServicios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpleadoTurnoServicios_Reservas_ReservaId",
                table: "EmpleadoTurnoServicios",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id");
        }
    }
}
