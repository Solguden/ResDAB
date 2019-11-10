using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantsDAB.Migrations
{
    public partial class ResturuntSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantID", "Address", "Name", "Type" },
                values: new object[] { "MC1", "Ronald McDonald Street 6969", "McDonalds", "Hurtig-Mad" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantID", "Address", "Name", "Type" },
                values: new object[] { "BK1", "Sunset Boulevard 420", "Burger King", "Sund Hurtig-Mad" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantID",
                keyValue: "BK1");

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantID",
                keyValue: "MC1");
        }
    }
}
