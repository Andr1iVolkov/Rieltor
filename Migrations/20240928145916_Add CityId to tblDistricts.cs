using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rieltor.Migrations
{
    /// <inheritdoc />
    public partial class AddCityIdtotblDistricts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "tblDistricts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblDistricts_CityId",
                table: "tblDistricts",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblDistricts_tblCities_CityId",
                table: "tblDistricts",
                column: "CityId",
                principalTable: "tblCities",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblDistricts_tblCities_CityId",
                table: "tblDistricts");

            migrationBuilder.DropIndex(
                name: "IX_tblDistricts_CityId",
                table: "tblDistricts");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "tblDistricts");
        }
    }
}
