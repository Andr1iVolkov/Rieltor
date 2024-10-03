using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rieltor.Migrations
{
    /// <inheritdoc />
    public partial class AddDistrictId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "District",
                table: "tblObjects");

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "tblObjects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tblDistricts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDistricts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblObjects_DistrictId",
                table: "tblObjects",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblObjects_tblDistricts_DistrictId",
                table: "tblObjects",
                column: "DistrictId",
                principalTable: "tblDistricts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblObjects_tblDistricts_DistrictId",
                table: "tblObjects");

            migrationBuilder.DropTable(
                name: "tblDistricts");

            migrationBuilder.DropIndex(
                name: "IX_tblObjects_DistrictId",
                table: "tblObjects");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "tblObjects");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "tblObjects",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
