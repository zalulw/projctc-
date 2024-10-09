using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicles.Database.Migrations
{
    /// <inheritdoc />
    public partial class Vehcile_Model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ModelId",
                table: "Vehicle",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ManufacturerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Model_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ModelId",
                table: "Vehicle",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturer_Name",
                table: "Manufacturer",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Model_ManufacturerId",
                table: "Model",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Model_Name",
                table: "Model",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Model_ModelId",
                table: "Vehicle",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Model_ModelId",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "Model");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_ModelId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Vehicle");
        }
    }
}
