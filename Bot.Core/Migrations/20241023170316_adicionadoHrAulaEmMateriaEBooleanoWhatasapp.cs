using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bot.Core.Migrations
{
    /// <inheritdoc />
    public partial class adicionadoHrAulaEmMateriaEBooleanoWhatasapp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_atualizar_por_whatsapp",
                table: "preferencia",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "hrs_aula",
                table: "materia",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_atualizar_por_whatsapp",
                table: "preferencia");

            migrationBuilder.DropColumn(
                name: "hrs_aula",
                table: "materia");
        }
    }
}
