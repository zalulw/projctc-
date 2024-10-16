using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lecso.Database.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JudgeId",
                table: "Competitions");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Competitions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "JudgeId",
                table: "Competitions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TeamId",
                table: "Competitions",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
