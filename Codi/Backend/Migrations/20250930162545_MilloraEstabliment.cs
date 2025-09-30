using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class MilloraEstabliment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Establiments_Clients_PropietariId",
                table: "Establiments");

            migrationBuilder.DropForeignKey(
                name: "FK_Ubicacions_Establiments_EstablimentId",
                table: "Ubicacions");

            migrationBuilder.DropIndex(
                name: "IX_Ubicacions_EstablimentId",
                table: "Ubicacions");

            migrationBuilder.DropColumn(
                name: "EstablimentId",
                table: "Ubicacions");

            migrationBuilder.RenameColumn(
                name: "PropietariId",
                table: "Establiments",
                newName: "UbicacioId");

            migrationBuilder.RenameIndex(
                name: "IX_Establiments_PropietariId",
                table: "Establiments",
                newName: "IX_Establiments_UbicacioId");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Establiments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Establiments_ClientId",
                table: "Establiments",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Establiments_Clients_ClientId",
                table: "Establiments",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Establiments_Ubicacions_UbicacioId",
                table: "Establiments",
                column: "UbicacioId",
                principalTable: "Ubicacions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Establiments_Clients_ClientId",
                table: "Establiments");

            migrationBuilder.DropForeignKey(
                name: "FK_Establiments_Ubicacions_UbicacioId",
                table: "Establiments");

            migrationBuilder.DropIndex(
                name: "IX_Establiments_ClientId",
                table: "Establiments");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Establiments");

            migrationBuilder.RenameColumn(
                name: "UbicacioId",
                table: "Establiments",
                newName: "PropietariId");

            migrationBuilder.RenameIndex(
                name: "IX_Establiments_UbicacioId",
                table: "Establiments",
                newName: "IX_Establiments_PropietariId");

            migrationBuilder.AddColumn<int>(
                name: "EstablimentId",
                table: "Ubicacions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacions_EstablimentId",
                table: "Ubicacions",
                column: "EstablimentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Establiments_Clients_PropietariId",
                table: "Establiments",
                column: "PropietariId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ubicacions_Establiments_EstablimentId",
                table: "Ubicacions",
                column: "EstablimentId",
                principalTable: "Establiments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
