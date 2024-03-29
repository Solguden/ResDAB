﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantsDAB;

namespace RestaurantsDAB.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20191108100430_SecondMigration_AddedEntities")]
    partial class SecondMigration_AddedEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("RestaurantsDAB.Models.Review", b =>
                {
                    b.HasOne("RestaurantsDAB.Models.Restaurant", "Restaurant")
                        .WithMany("Reviews")
                        .HasForeignKey("RestaurantID");
                });
#pragma warning restore 612, 618
        }
    }
}
