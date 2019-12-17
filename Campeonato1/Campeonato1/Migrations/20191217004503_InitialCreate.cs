using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Campeonato1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "jogadores",
                columns: table => new
                {
                    JogadorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: false),
                    idade = table.Column<int>(nullable: false),
                    nacionalidade = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jogadores", x => x.JogadorId);
                });

            migrationBuilder.CreateTable(
                name: "placares",
                columns: table => new
                {
                    PlacarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JogadorId = table.Column<int>(nullable: false),
                    total = table.Column<float>(nullable: false),
                    data = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_placares", x => x.PlacarId);
                    table.ForeignKey(
                        name: "FK_placares_jogadores_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "jogadores",
                        principalColumn: "JogadorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_placares_JogadorId",
                table: "placares",
                column: "JogadorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "placares");

            migrationBuilder.DropTable(
                name: "jogadores");
        }
    }
}
