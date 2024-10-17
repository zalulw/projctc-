using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tanc.Database.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.PostalCode);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Street",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    DoorNumber = table.Column<long>(type: "bigint", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Street", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Street_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "PostalCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Competition",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    StartDate = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    EndDate = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    StreetId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competition_Street_StreetId",
                        column: x => x.StreetId,
                        principalTable: "Street",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Choreographer = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Points = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    CompetitionEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Team_Competition_CompetitionEntityId",
                        column: x => x.CompetitionEntityId,
                        principalTable: "Competition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Team_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    DateOfBirth = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    StreetId = table.Column<long>(type: "bigint", nullable: false),
                    TeamEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Member_Street_StreetId",
                        column: x => x.StreetId,
                        principalTable: "Street",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Member_Team_TeamEntityId",
                        column: x => x.TeamEntityId,
                        principalTable: "Team",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Competition_StreetId",
                table: "Competition",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_StreetId",
                table: "Member",
                column: "StreetId");

            migrationBuilder.CreateIndex(
                name: "IX_Member_TeamEntityId",
                table: "Member",
                column: "TeamEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Street_CityId",
                table: "Street",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_CompetitionEntityId",
                table: "Team",
                column: "CompetitionEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_CountryId",
                table: "Team",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_TeamName",
                table: "Team",
                column: "TeamName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Competition");

            migrationBuilder.DropTable(
                name: "Street");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
