using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantsDAB.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dishes_Reviews_ReviewID",
                table: "dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_guests_Reviews_ReviewsReviewID",
                table: "guests");

            migrationBuilder.RenameColumn(
                name: "ReviewID",
                table: "Reviews",
                newName: "ReviewId");

            migrationBuilder.RenameColumn(
                name: "ReviewsReviewID",
                table: "guests",
                newName: "ReviewsReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_guests_ReviewsReviewID",
                table: "guests",
                newName: "IX_guests_ReviewsReviewId");

            migrationBuilder.RenameColumn(
                name: "ReviewID",
                table: "dishes",
                newName: "ReviewId");

            migrationBuilder.RenameIndex(
                name: "IX_dishes_ReviewID",
                table: "dishes",
                newName: "IX_dishes_ReviewId");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "GuestID", "Name", "WaiterID" },
                values: new object[,]
                {
                    { "67", null, "Djebs Djakketyv", null },
                    { "69", null, "Jørgen Ingenarm", null },
                    { "68", null, "Henrik DABsemand", null },
                    { "65", null, "Blobs Blobbermand", null },
                    { "64", null, "Muubs Megetsyg", null },
                    { "61", null, "Jeps Jepsemand", null },
                    { "62", null, "Jobs Jobsemand", null },
                    { "63", null, "Flobs Flobsemand", null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "RestaurantID", "Stars", "Text" },
                values: new object[,]
                {
                    { "R03", null, 5, "Jeg elsker Hurtig-mad. Det var bare lyn-hurtigt! :)" },
                    { "R02", null, 3, "Jeg kan godt lide Hurtig-mad. Det kunne dog have været hurtigere" },
                    { "R01", null, 1, "Jeg hader Hurtig-mad. Det var ikke hurtigt nok" }
                });

            migrationBuilder.InsertData(
                table: "dishes",
                columns: new[] { "DishId", "DishName", "Price", "ReviewId", "Type" },
                values: new object[,]
                {
                    { "1334", "Cheese Burger", 9.9499999999999993, null, "Coin Offer" },
                    { "1337", "Double-Whopper", 29.949999999999999, null, "Lidt hurtigere burger" },
                    { "1336", "Whopper", 14.949999999999999, null, "Langsom burger" },
                    { "1335", "Happy Meal", 36.950000000000003, null, "Børne Menu" }
                });

            migrationBuilder.InsertData(
                table: "guests",
                columns: new[] { "GuestId", "ReviewsReviewId", "Time" },
                values: new object[,]
                {
                    { "419", null, new DateTime(2019, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "418", null, new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "417", null, new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { "420", null, new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "tables",
                columns: new[] { "TableId", "GuestId", "Number", "RestaurantID" },
                values: new object[,]
                {
                    { "6001", null, 10, null },
                    { "6002", null, 20, null },
                    { "6003", null, 30, null },
                    { "6004", null, 40, null }
                });

            migrationBuilder.InsertData(
                table: "waiters",
                columns: new[] { "WaiterId", "Salary" },
                values: new object[,]
                {
                    { "8007", 2700.0 },
                    { "8005", 2500.0 },
                    { "8006", 2600.0 },
                    { "8008", 2800.0 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_dishes_Reviews_ReviewId",
                table: "dishes",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_guests_Reviews_ReviewsReviewId",
                table: "guests",
                column: "ReviewsReviewId",
                principalTable: "Reviews",
                principalColumn: "ReviewId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dishes_Reviews_ReviewId",
                table: "dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_guests_Reviews_ReviewsReviewId",
                table: "guests");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "61");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "62");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "63");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "64");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "65");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "67");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "68");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: "69");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "R01");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "R02");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: "R03");

            migrationBuilder.DeleteData(
                table: "dishes",
                keyColumn: "DishId",
                keyValue: "1334");

            migrationBuilder.DeleteData(
                table: "dishes",
                keyColumn: "DishId",
                keyValue: "1335");

            migrationBuilder.DeleteData(
                table: "dishes",
                keyColumn: "DishId",
                keyValue: "1336");

            migrationBuilder.DeleteData(
                table: "dishes",
                keyColumn: "DishId",
                keyValue: "1337");

            migrationBuilder.DeleteData(
                table: "guests",
                keyColumn: "GuestId",
                keyValue: "417");

            migrationBuilder.DeleteData(
                table: "guests",
                keyColumn: "GuestId",
                keyValue: "418");

            migrationBuilder.DeleteData(
                table: "guests",
                keyColumn: "GuestId",
                keyValue: "419");

            migrationBuilder.DeleteData(
                table: "guests",
                keyColumn: "GuestId",
                keyValue: "420");

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "TableId",
                keyValue: "6001");

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "TableId",
                keyValue: "6002");

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "TableId",
                keyValue: "6003");

            migrationBuilder.DeleteData(
                table: "tables",
                keyColumn: "TableId",
                keyValue: "6004");

            migrationBuilder.DeleteData(
                table: "waiters",
                keyColumn: "WaiterId",
                keyValue: "8005");

            migrationBuilder.DeleteData(
                table: "waiters",
                keyColumn: "WaiterId",
                keyValue: "8006");

            migrationBuilder.DeleteData(
                table: "waiters",
                keyColumn: "WaiterId",
                keyValue: "8007");

            migrationBuilder.DeleteData(
                table: "waiters",
                keyColumn: "WaiterId",
                keyValue: "8008");

            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "Reviews",
                newName: "ReviewID");

            migrationBuilder.RenameColumn(
                name: "ReviewsReviewId",
                table: "guests",
                newName: "ReviewsReviewID");

            migrationBuilder.RenameIndex(
                name: "IX_guests_ReviewsReviewId",
                table: "guests",
                newName: "IX_guests_ReviewsReviewID");

            migrationBuilder.RenameColumn(
                name: "ReviewId",
                table: "dishes",
                newName: "ReviewID");

            migrationBuilder.RenameIndex(
                name: "IX_dishes_ReviewId",
                table: "dishes",
                newName: "IX_dishes_ReviewID");

            migrationBuilder.AddForeignKey(
                name: "FK_dishes_Reviews_ReviewID",
                table: "dishes",
                column: "ReviewID",
                principalTable: "Reviews",
                principalColumn: "ReviewID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_guests_Reviews_ReviewsReviewID",
                table: "guests",
                column: "ReviewsReviewID",
                principalTable: "Reviews",
                principalColumn: "ReviewID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
