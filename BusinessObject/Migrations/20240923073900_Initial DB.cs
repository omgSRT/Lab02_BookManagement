using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObject.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Presses",
                columns: table => new
                {
                    PressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PressName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presses", x => x.PressId);
                    table.ForeignKey(
                        name: "FK_Presses_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IBSN = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    PressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Presses_PressId",
                        column: x => x.PressId,
                        principalTable: "Presses",
                        principalColumn: "PressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Street" },
                values: new object[,]
                {
                    { 1, "HCM City", "Nguyen Hue Street" },
                    { 2, "HCM City", "Le Loi Street" },
                    { 3, "Binh Duong", "Binh Duong Revenue" },
                    { 4, "Binh Duong", "Hung Vuong Street" },
                    { 5, "HCM City", "Pham Ngu Lao Street" },
                    { 6, "HCM City", "Hai Ba Trung Street" },
                    { 7, "Binh Duong", "Tran Hung Dao Street" },
                    { 8, "Binh Duong", "Le Hong Phong Street" },
                    { 9, "HCM City", "Ton Duc Thang Street" },
                    { 10, "HCM City", "Dien Bien Phu Street" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Book" },
                    { 2, "Magazine" },
                    { 3, "EBook" }
                });

            migrationBuilder.InsertData(
                table: "Presses",
                columns: new[] { "PressId", "CategoryId", "PressName" },
                values: new object[,]
                {
                    { 1, 1, "Kim Dong Publishing House" },
                    { 2, 1, "Tre Publishing House" },
                    { 3, 1, "National Political Publishing House" },
                    { 4, 1, "General Publishing House" },
                    { 5, 2, "Communication And News Publishing House" },
                    { 6, 1, "Education Publishing House" },
                    { 7, 2, "Women Publishing House" },
                    { 8, 2, "Lao Dong Publishing House" },
                    { 9, 3, "Science And Technology Publishing House" },
                    { 10, 3, "Culture And Arts Publishing House" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AddressId",
                table: "Books",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PressId",
                table: "Books",
                column: "PressId");

            migrationBuilder.CreateIndex(
                name: "IX_Presses_CategoryId",
                table: "Presses",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Presses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
