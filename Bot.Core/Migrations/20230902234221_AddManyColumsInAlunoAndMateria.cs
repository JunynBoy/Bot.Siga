using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bot.Core.Migrations
{
    /// <inheritdoc />
    public partial class AddManyColumsInAlunoAndMateria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "professor",
                table: "materia",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "codigo",
                table: "materia",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<bool>(
                name: "atualizar-por-email",
                table: "Aluno",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "atualizar-por-whatsapp",
                table: "Aluno",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Aluno",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "whatsapp",
                table: "Aluno",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "codigo",
                table: "materia");

            migrationBuilder.DropColumn(
                name: "atualizar-por-email",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "atualizar-por-whatsapp",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "whatsapp",
                table: "Aluno");

            migrationBuilder.UpdateData(
                table: "materia",
                keyColumn: "professor",
                keyValue: null,
                column: "professor",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "professor",
                table: "materia",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
