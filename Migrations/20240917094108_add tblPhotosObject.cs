using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rieltor.Migrations
{
    /// <inheritdoc />
    public partial class addtblPhotosObject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblPhotosObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPhotosObjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblPhotosObjects_tblObjects_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "tblObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblPhotosObjects_ObjectId",
                table: "tblPhotosObjects",
                column: "ObjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblPhotosObjects");
        }
    }
}
