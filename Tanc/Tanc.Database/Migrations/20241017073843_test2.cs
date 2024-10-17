using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanc.Database.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Street_City_PostalCode",
                table: "Street");

            migrationBuilder.RenameColumn(
                name: "PostalCode",
                table: "Street",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Street_PostalCode",
                table: "Street",
                newName: "IX_Street_CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Street_City_CityId",
                table: "Street",
                column: "CityId",
                principalTable: "City",
                principalColumn: "PostalCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Street_City_CityId",
                table: "Street");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Street",
                newName: "PostalCode");

            migrationBuilder.RenameIndex(
                name: "IX_Street_CityId",
                table: "Street",
                newName: "IX_Street_PostalCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Street_City_PostalCode",
                table: "Street",
                column: "PostalCode",
                principalTable: "City",
                principalColumn: "PostalCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
