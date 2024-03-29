﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantsDAB;

namespace RestaurantsDAB.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20191108101337_ThirdMigration_AddedEntities2")]
    partial class ThirdMigration_AddedEntities2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestaurantsDAB.Models.Dish", b =>
                {
                    b.Property<string>("DishId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ReviewID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DishId");

                    b.HasIndex("ReviewID");

                    b.ToTable("dishes");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Guest", b =>
                {
                    b.Property<string>("GuestId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ReviewsReviewID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("GuestId");

                    b.HasIndex("ReviewsReviewID");

                    b.ToTable("guests");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Person", b =>
                {
                    b.Property<string>("PersonId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GuestID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaiterID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PersonId");

                    b.HasIndex("GuestID")
                        .IsUnique()
                        .HasFilter("[GuestID] IS NOT NULL");

                    b.HasIndex("WaiterID")
                        .IsUnique()
                        .HasFilter("[WaiterID] IS NOT NULL");

                    b.ToTable("People");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Relationship.GuestDish", b =>
                {
                    b.Property<string>("GuestId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DishId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("GuestId", "DishId");

                    b.HasIndex("DishId");

                    b.ToTable("GuestDish");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Relationship.RestaurantDish", b =>
                {
                    b.Property<string>("DishId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RestaurantId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DishId", "RestaurantId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("RestaurantDish");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Relationship.WaiterTable", b =>
                {
                    b.Property<string>("WaiterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TableId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("WaiterId", "TableId");

                    b.HasIndex("TableId");

                    b.ToTable("WaiterTable");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Restaurant", b =>
                {
                    b.Property<string>("RestaurantID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantID");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Review", b =>
                {
                    b.Property<string>("ReviewID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RestaurantID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewID");

                    b.HasIndex("RestaurantID");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Table", b =>
                {
                    b.Property<string>("TableId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GuestId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TableId");

                    b.HasIndex("GuestId");

                    b.HasIndex("RestaurantID");

                    b.ToTable("tables");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Waiter", b =>
                {
                    b.Property<string>("WaiterId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("WaiterId");

                    b.ToTable("waiters");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Dish", b =>
                {
                    b.HasOne("RestaurantsDAB.Models.Review", "Review")
                        .WithMany("Dishes")
                        .HasForeignKey("ReviewID");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Guest", b =>
                {
                    b.HasOne("RestaurantsDAB.Models.Review", "Reviews")
                        .WithMany("Guests")
                        .HasForeignKey("ReviewsReviewID");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Person", b =>
                {
                    b.HasOne("RestaurantsDAB.Models.Guest", "Guest")
                        .WithOne("Person")
                        .HasForeignKey("RestaurantsDAB.Models.Person", "GuestID");

                    b.HasOne("RestaurantsDAB.Models.Waiter", "Waiter")
                        .WithOne("Person")
                        .HasForeignKey("RestaurantsDAB.Models.Person", "WaiterID");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Relationship.GuestDish", b =>
                {
                    b.HasOne("RestaurantsDAB.Models.Dish", "Dish")
                        .WithMany("GuestDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantsDAB.Models.Guest", "Guest")
                        .WithMany("GuestDishes")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Relationship.RestaurantDish", b =>
                {
                    b.HasOne("RestaurantsDAB.Models.Dish", "Dish")
                        .WithMany("RestaurantDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantsDAB.Models.Restaurant", "Restaurant")
                        .WithMany("RestaurantDishes")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Relationship.WaiterTable", b =>
                {
                    b.HasOne("RestaurantsDAB.Models.Table", "Table")
                        .WithMany("WaiterTables")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantsDAB.Models.Waiter", "Waiter")
                        .WithMany("WaiterTables")
                        .HasForeignKey("WaiterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Review", b =>
                {
                    b.HasOne("RestaurantsDAB.Models.Restaurant", "Restaurant")
                        .WithMany("Reviews")
                        .HasForeignKey("RestaurantID");
                });

            modelBuilder.Entity("RestaurantsDAB.Models.Table", b =>
                {
                    b.HasOne("RestaurantsDAB.Models.Guest", "Guest")
                        .WithMany("Tables")
                        .HasForeignKey("GuestId");

                    b.HasOne("RestaurantsDAB.Models.Restaurant", "Restaurant")
                        .WithMany("Tables")
                        .HasForeignKey("RestaurantID");
                });
#pragma warning restore 612, 618
        }
    }
}
