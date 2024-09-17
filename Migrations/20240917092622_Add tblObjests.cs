using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rieltor.Migrations
{
    /// <inheritdoc />
    public partial class AddtblObjests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeOfObjectId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    District = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumberOfRooms = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    RieltorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblObjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblObjects_tblCities_CityId",
                        column: x => x.CityId,
                        principalTable: "tblCities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblObjects_tblRieltors_RieltorId",
                        column: x => x.RieltorId,
                        principalTable: "tblRieltors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblObjects_tblTypesOfObjects_TypeOfObjectId",
                        column: x => x.TypeOfObjectId,
                        principalTable: "tblTypesOfObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblObjects_CityId",
                table: "tblObjects",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_tblObjects_RieltorId",
                table: "tblObjects",
                column: "RieltorId");

            migrationBuilder.CreateIndex(
                name: "IX_tblObjects_TypeOfObjectId",
                table: "tblObjects",
                column: "TypeOfObjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblObjects");
        }
    }
}
