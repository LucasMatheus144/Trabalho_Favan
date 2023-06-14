using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetcoApp.Migrations
{
    public partial class InitialeCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_tipoId",
                table: "Pets",
                column: "tipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Tipo_tipoId",
                table: "Pets",
                column: "tipoId",
                principalTable: "Tipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Tipo_tipoId",
                table: "Pets");

            migrationBuilder.DropTable(
                name: "Tipo");

            migrationBuilder.DropIndex(
                name: "IX_Pets_tipoId",
                table: "Pets");
        }
    }
}
