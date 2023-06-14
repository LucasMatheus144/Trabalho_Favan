using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetcoApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    apelido_Animal = table.Column<string>(type: "TEXT", nullable: true),
                    tipoId = table.Column<int>(type: "INTEGER", nullable: false),
                    tipo = table.Column<string>(type: "TEXT", nullable: true),
                    servico = table.Column<string>(type: "TEXT", nullable: true),
                    dia_chegada = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
