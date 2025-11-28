using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogicaDatos.Migrations
{
    /// <inheritdoc />
    public partial class asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpleadoTurnoServicio_Reservas_ReservaId",
                table: "EmpleadoTurnoServicio");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpleadoTurnoServicio_Servicios_ServicioId",
                table: "EmpleadoTurnoServicio");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpleadoTurnoServicio_Usuarios_EmpleadoId",
                table: "EmpleadoTurnoServicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmpleadoTurnoServicio",
                table: "EmpleadoTurnoServicio");

            migrationBuilder.RenameTable(
                name: "EmpleadoTurnoServicio",
                newName: "EmpleadoTurnoServicios");

            migrationBuilder.RenameIndex(
                name: "IX_EmpleadoTurnoServicio_ServicioId",
                table: "EmpleadoTurnoServicios",
                newName: "IX_EmpleadoTurnoServicios_ServicioId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpleadoTurnoServicio_ReservaId",
                table: "EmpleadoTurnoServicios",
                newName: "IX_EmpleadoTurnoServicios_ReservaId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpleadoTurnoServicio_EmpleadoId",
                table: "EmpleadoTurnoServicios",
                newName: "IX_EmpleadoTurnoServicios_EmpleadoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmpleadoTurnoServicios",
                table: "EmpleadoTurnoServicios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpleadoTurnoServicios_Reservas_ReservaId",
                table: "EmpleadoTurnoServicios",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpleadoTurnoServicios_Servicios_ServicioId",
                table: "EmpleadoTurnoServicios",
                column: "ServicioId",
                principalTable: "Servicios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpleadoTurnoServicios_Usuarios_EmpleadoId",
                table: "EmpleadoTurnoServicios",
                column: "EmpleadoId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmpleadoTurnoServicios_Reservas_ReservaId",
                table: "EmpleadoTurnoServicios");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpleadoTurnoServicios_Servicios_ServicioId",
                table: "EmpleadoTurnoServicios");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpleadoTurnoServicios_Usuarios_EmpleadoId",
                table: "EmpleadoTurnoServicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmpleadoTurnoServicios",
                table: "EmpleadoTurnoServicios");

            migrationBuilder.RenameTable(
                name: "EmpleadoTurnoServicios",
                newName: "EmpleadoTurnoServicio");

            migrationBuilder.RenameIndex(
                name: "IX_EmpleadoTurnoServicios_ServicioId",
                table: "EmpleadoTurnoServicio",
                newName: "IX_EmpleadoTurnoServicio_ServicioId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpleadoTurnoServicios_ReservaId",
                table: "EmpleadoTurnoServicio",
                newName: "IX_EmpleadoTurnoServicio_ReservaId");

            migrationBuilder.RenameIndex(
                name: "IX_EmpleadoTurnoServicios_EmpleadoId",
                table: "EmpleadoTurnoServicio",
                newName: "IX_EmpleadoTurnoServicio_EmpleadoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmpleadoTurnoServicio",
                table: "EmpleadoTurnoServicio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpleadoTurnoServicio_Reservas_ReservaId",
                table: "EmpleadoTurnoServicio",
                column: "ReservaId",
                principalTable: "Reservas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpleadoTurnoServicio_Servicios_ServicioId",
                table: "EmpleadoTurnoServicio",
                column: "ServicioId",
                principalTable: "Servicios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpleadoTurnoServicio_Usuarios_EmpleadoId",
                table: "EmpleadoTurnoServicio",
                column: "EmpleadoId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
