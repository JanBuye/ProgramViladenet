using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class CreacioViladenetBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlocksHores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Disp = table.Column<bool>(type: "bit", nullable: false),
                    Inici = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Final = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Treballat = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlocksHores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognom1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognom2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Treballadors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognom1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognom2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vehicle = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treballadors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Establiments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropietariId = table.Column<int>(type: "int", nullable: false),
                    Tipus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Accesibilitat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Establiments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Establiments_Clients_PropietariId",
                        column: x => x.PropietariId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    DiaInici = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaFi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipus = table.Column<int>(type: "int", nullable: false),
                    EstablimentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Establiments_EstablimentId",
                        column: x => x.EstablimentId,
                        principalTable: "Establiments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ubicacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstablimentId = table.Column<int>(type: "int", nullable: false),
                    CordsX = table.Column<double>(type: "float", nullable: false),
                    CordsY = table.Column<double>(type: "float", nullable: false),
                    CodiPostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poblacio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ubicacions_Establiments_EstablimentId",
                        column: x => x.EstablimentId,
                        principalTable: "Establiments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlocksFeina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(type: "int", nullable: false),
                    ListTreballadors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoraInici = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConductorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlocksFeina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlocksFeina_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlocksFeina_Treballadors_ConductorId",
                        column: x => x.ConductorId,
                        principalTable: "Treballadors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlocksFeina_ConductorId",
                table: "BlocksFeina",
                column: "ConductorId");

            migrationBuilder.CreateIndex(
                name: "IX_BlocksFeina_EventId",
                table: "BlocksFeina",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Establiments_PropietariId",
                table: "Establiments",
                column: "PropietariId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ClientId",
                table: "Events",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EstablimentId",
                table: "Events",
                column: "EstablimentId");

            migrationBuilder.CreateIndex(
                name: "IX_Ubicacions_EstablimentId",
                table: "Ubicacions",
                column: "EstablimentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlocksFeina");

            migrationBuilder.DropTable(
                name: "BlocksHores");

            migrationBuilder.DropTable(
                name: "Ubicacions");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Treballadors");

            migrationBuilder.DropTable(
                name: "Establiments");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
