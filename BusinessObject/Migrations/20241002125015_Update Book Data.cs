using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessObject.Migrations
{
    public partial class UpdateBookData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AddressId", "Author", "IBSN", "PressId", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Fujiko F. Fujio", "9786042073143", 1, 14376m, "Doraemon" },
                    { 2, 2, "Antoine de Saint-Exupéry", "9786041073007", 2, 25200m, "The Little Prince" },
                    { 3, 3, "William Duiker", "9786043097919", 3, 30600m, "Ho Chi Minh: A Life" },
                    { 4, 4, "Nguyen Du", "9786041156545", 4, 18000m, "The Tale of Kieu" },
                    { 5, 5, "Forbes Media", "9786042129877", 5, 16776m, "Forbes Magazine" },
                    { 6, 6, "Nguyen Quang Hieu", "9786042028981", 6, 36000m, "Textbook of Chemistry" },
                    { 7, 7, "Various", "9786042130425", 7, 11976m, "Women's World Magazine" },
                    { 8, 8, "Nguyen Van Thanh", "9786042032517", 8, 22200m, "Labor and Employment Law" },
                    { 9, 9, "Le Van Minh", "9786043049989", 9, 45576m, "Principles of Technology" },
                    { 10, 10, "Le Huy Toan", "9786045068940", 10, 49200m, "Vietnamese Art Through the Ages" },
                    { 11, 1, "J.K. Rowling", "9786041072545", 2, 21576m, "Harry Potter and the Philosopher's Stone" },
                    { 12, 2, "Truong Buu Lam", "9786042067812", 3, 33000m, "A Brief History of Vietnam" },
                    { 13, 3, "Le Thi Kim", "9786043152176", 4, 14376m, "Cooking with Love" },
                    { 14, 4, "Various Authors", "9786041092182", 5, 18000m, "Business News Magazine" },
                    { 15, 5, "Pham Van Dinh", "9786042076541", 6, 39600m, "Advanced Mathematics" },
                    { 16, 6, "Various", "9786042151430", 7, 95760m, "Women's Weekly Magazine" },
                    { 17, 7, "Nguyen Thi Lan", "9786043087103", 8, 26400m, "Employment Law Handbook" },
                    { 18, 8, "Le Duc Thinh", "9786044087217", 9, 54600m, "The Science of Everything" },
                    { 19, 9, "Tran Quang Huy", "9786045089128", 10, 61200m, "Vietnamese Folk Art" },
                    { 20, 10, "Akira Toriyama", "9786042075652", 1, 15600m, "Dragon Ball" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);
        }
    }
}
