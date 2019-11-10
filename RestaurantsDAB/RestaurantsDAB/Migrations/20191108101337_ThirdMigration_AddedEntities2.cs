using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantsDAB.Migrations
{
    public partial class ThirdMigration_AddedEntities2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dishes",
                columns: table => new
                {
                    DishId = table.Column<string>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    DishName = table.Column<string>(nullable: false),
                    ReviewID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dishes", x => x.DishId);
                    table.ForeignKey(
                        name: "FK_dishes_Reviews_ReviewID",
                        column: x => x.ReviewID,
                        principalTable: "Reviews",
                        principalColumn: "ReviewID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "guests",
                columns: table => new
                {
                    GuestId = table.Column<string>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    ReviewsReviewID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guests", x => x.GuestId);
                    table.ForeignKey(
                        name: "FK_guests_Reviews_ReviewsReviewID",
                        column: x => x.ReviewsReviewID,
                        principalTable: "Reviews",
                        principalColumn: "ReviewID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "waiters",
                columns: table => new
                {
                    WaiterId = table.Column<string>(nullable: false),
                    Salary = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_waiters", x => x.WaiterId);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantDish",
                columns: table => new
                {
                    RestaurantId = table.Column<string>(nullable: false),
                    DishId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantDish", x => new { x.DishId, x.RestaurantId });
                    table.ForeignKey(
                        name: "FK_RestaurantDish_dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantDish_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuestDish",
                columns: table => new
                {
                    GuestId = table.Column<string>(nullable: false),
                    DishId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestDish", x => new { x.GuestId, x.DishId });
                    table.ForeignKey(
                        name: "FK_GuestDish_dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuestDish_guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tables",
                columns: table => new
                {
                    TableId = table.Column<string>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    RestaurantID = table.Column<string>(nullable: true),
                    GuestId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tables", x => x.TableId);
                    table.ForeignKey(
                        name: "FK_tables_guests_GuestId",
                        column: x => x.GuestId,
                        principalTable: "guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tables_Restaurants_RestaurantID",
                        column: x => x.RestaurantID,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    WaiterID = table.Column<string>(nullable: true),
                    GuestID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_People_guests_GuestID",
                        column: x => x.GuestID,
                        principalTable: "guests",
                        principalColumn: "GuestId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_People_waiters_WaiterID",
                        column: x => x.WaiterID,
                        principalTable: "waiters",
                        principalColumn: "WaiterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WaiterTable",
                columns: table => new
                {
                    WaiterId = table.Column<string>(nullable: false),
                    TableId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaiterTable", x => new { x.WaiterId, x.TableId });
                    table.ForeignKey(
                        name: "FK_WaiterTable_tables_TableId",
                        column: x => x.TableId,
                        principalTable: "tables",
                        principalColumn: "TableId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WaiterTable_waiters_WaiterId",
                        column: x => x.WaiterId,
                        principalTable: "waiters",
                        principalColumn: "WaiterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_dishes_ReviewID",
                table: "dishes",
                column: "ReviewID");

            migrationBuilder.CreateIndex(
                name: "IX_GuestDish_DishId",
                table: "GuestDish",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_guests_ReviewsReviewID",
                table: "guests",
                column: "ReviewsReviewID");

            migrationBuilder.CreateIndex(
                name: "IX_People_GuestID",
                table: "People",
                column: "GuestID",
                unique: true,
                filter: "[GuestID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_People_WaiterID",
                table: "People",
                column: "WaiterID",
                unique: true,
                filter: "[WaiterID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantDish_RestaurantId",
                table: "RestaurantDish",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_tables_GuestId",
                table: "tables",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_tables_RestaurantID",
                table: "tables",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "IX_WaiterTable_TableId",
                table: "WaiterTable",
                column: "TableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuestDish");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "RestaurantDish");

            migrationBuilder.DropTable(
                name: "WaiterTable");

            migrationBuilder.DropTable(
                name: "dishes");

            migrationBuilder.DropTable(
                name: "tables");

            migrationBuilder.DropTable(
                name: "waiters");

            migrationBuilder.DropTable(
                name: "guests");
        }
    }
}
