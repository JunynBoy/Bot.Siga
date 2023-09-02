using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bot.Core.Migrations
{
    /// <inheritdoc />
    public partial class DelTurnoInMateriaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "turno",
                table: "materia");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "turno",
                table: "materia",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
