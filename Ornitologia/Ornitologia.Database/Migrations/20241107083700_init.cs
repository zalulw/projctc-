using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ornitologia.Database.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tribe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TribeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tribe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Street",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Street", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Street_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subclass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubclassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TribeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subclass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subclass_Tribe_TribeId",
                        column: x => x.TribeId,
                        principalTable: "Tribe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    MembershipCardNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetId = table.Column<int>(type: "int", nullable: false),
                    StartOfMembership = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndOfMembership = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.MembershipCardNumber);
                    table.ForeignKey(
                        name: "FK_Member_Street_StreetId",
                        column: x => x.StreetId,
                        principalTable: "Street",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BirdClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubclassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirdClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BirdClass_Subclass_SubclassId",
                        column: x => x.SubclassId,
                        principalTable: "Subclass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeciesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Species_BirdClass_ClassId",
                        column: x => x.ClassId,
                        principalTable: "BirdClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bird",
                columns: table => new
                {
                    RingNumber = table.Column<int>(type: "int", nullable: false),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    DateOfRinging = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhereRinged = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpeciesEntityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bird", x => x.RingNumber);
                    table.ForeignKey(
                        name: "FK_Bird_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MembershipCardNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bird_Species_SpeciesEntityId",
                        column: x => x.SpeciesEntityId,
                        principalTable: "Species",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bird_Species_SpeciesId",
                        column: x => x.SpeciesId,
                        principalTable: "Species",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirdId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Note_Bird_BirdId",
                        column: x => x.BirdId,
                        principalTable: "Bird",
                        principalColumn: "RingNumber");
                    table.ForeignKey(
                        name: "FK_Note_Member_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Member",
                        principalColumn: "MembershipCardNumber");
                    table.ForeignKey(
                        name: "FK_Note_Street_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Street",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bird_MemberId",
                table: "Bird",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Bird_SpeciesEntityId",
                table: "Bird",
                column: "SpeciesEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bird_SpeciesId",
                table: "Bird",
                column: "SpeciesId");

            migrationBuilder.CreateIndex(
                name: "IX_BirdClass_SubclassId",
                table: "BirdClass",
                column: "SubclassId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Member_StreetId",
                table: "Member",
                column: "StreetId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Note_BirdId",
                table: "Note",
                column: "BirdId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_LocationId",
                table: "Note",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_MemberId",
                table: "Note",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Species_ClassId",
                table: "Species",
                column: "ClassId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Street_CityId",
                table: "Street",
                column: "CityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subclass_TribeId",
                table: "Subclass",
                column: "TribeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "Bird");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Street");

            migrationBuilder.DropTable(
                name: "BirdClass");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Subclass");

            migrationBuilder.DropTable(
                name: "Tribe");
        }
    }
}
