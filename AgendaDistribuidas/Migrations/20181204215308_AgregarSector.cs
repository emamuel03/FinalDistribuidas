using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AgendaDistribuidas.Migrations
{
    public partial class AgregarSector : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectorId",
                table: "Contacto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sector",
                columns: table => new
                {
                    SectorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.SectorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_SectorId",
                table: "Contacto",
                column: "SectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacto_Sector_SectorId",
                table: "Contacto",
                column: "SectorId",
                principalTable: "Sector",
                principalColumn: "SectorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacto_Sector_SectorId",
                table: "Contacto");

            migrationBuilder.DropTable(
                name: "Sector");

            migrationBuilder.DropIndex(
                name: "IX_Contacto_SectorId",
                table: "Contacto");

            migrationBuilder.DropColumn(
                name: "SectorId",
                table: "Contacto");
        }
    }
}
