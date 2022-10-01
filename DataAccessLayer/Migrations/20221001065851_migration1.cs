using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CtgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CtgDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CtgImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CtgStatus = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrdName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdImage3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrdPrice = table.Column<int>(type: "int", nullable: true),
                    PrdStatus = table.Column<bool>(type: "bit", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
