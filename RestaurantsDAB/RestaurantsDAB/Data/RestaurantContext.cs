using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantsDAB.Models;
using RestaurantsDAB.Models.Relationship;

namespace RestaurantsDAB
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions options) : base(options) { }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Waiter> waiters { get; set; }
        public DbSet<Table> tables { get; set; }
        public DbSet<Dish> dishes { get; set; }
        public DbSet<Guest> guests { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Dish - RestaurantDish (many-to-many relationship)
            modelBuilder.Entity<RestaurantDish>().HasKey(p => new { p.DishId, p.RestaurantId });
            modelBuilder.Entity<RestaurantDish>()
                .HasOne(rd => rd.Dish)
                .WithMany(d => d.RestaurantDishes)
                .HasForeignKey(rd => rd.DishId);
            modelBuilder.Entity<RestaurantDish>()
                .HasOne(rd => rd.Restaurant)
                .WithMany(r => r.RestaurantDishes)
                .HasForeignKey(rd => rd.RestaurantId);

            // Guest - Dish (many to many relationship)
            modelBuilder.Entity<GuestDish>().HasKey(p => new { p.GuestId, p.DishId });
            modelBuilder.Entity<GuestDish>()
             .HasOne(plb => plb.Guest)
             .WithMany(b => b.GuestDishes)
             .HasForeignKey(plb => plb.GuestId);
            modelBuilder.Entity<GuestDish>()
             .HasOne(plb => plb.Dish)
             .WithMany(pl => pl.GuestDishes)
             .HasForeignKey(plb => plb.DishId);

            // Waiter - Table (many to many relationship)
            modelBuilder.Entity<WaiterTable>().HasKey(p => new { p.WaiterId, p.TableId });
            modelBuilder.Entity<WaiterTable>()
             .HasOne(plb => plb.Waiter)
             .WithMany(b => b.WaiterTables)
             .HasForeignKey(plb => plb.WaiterId);
            modelBuilder.Entity<WaiterTable>()
             .HasOne(plb => plb.Table)
             .WithMany(pl => pl.WaiterTables)
             .HasForeignKey(plb => plb.TableId);

            //Data seeding Restaurant
            modelBuilder.Entity<Restaurant>()
                .HasData(new Restaurant()
                {
                    RestaurantID = "MC1",
                    Address = "Ronald McDonald Street 6969",
                    Name = "McDonalds",
                    Type = "Hurtig-Mad",
                });
            modelBuilder.Entity<Restaurant>()
                .HasData(new Restaurant()
                {
                    RestaurantID = "BK1",
                    Address = "Sunset Boulevard 420",
                    Name = "Burger King",
                    Type = "Sund Hurtig-Mad",
                });

            //Data seeding Table
            modelBuilder.Entity<Table>()
                .HasData(new Table()
                {
                    TableId = "6001",
                    Number = 10,
                });
            modelBuilder.Entity<Table>()
                .HasData(new Table()
                {
                    TableId = "6002",
                    Number = 20,
                });
            modelBuilder.Entity<Table>()
                .HasData(new Table()
                {
                    TableId = "6003",
                    Number = 30,
                });
            modelBuilder.Entity<Table>()
               .HasData(new Table()
               {
                   TableId = "6004",
                   Number = 40,
               });

            //Data seeding Table
            modelBuilder.Entity<Review>()
                   .HasData(new Review()
                   {
                       ReviewId = "R01",
                       Stars = 1,
                       Text = "Jeg hader Hurtig-mad. Det var ikke hurtigt nok",
                   });
            modelBuilder.Entity<Review>()
               .HasData(new Review()
               {
                   ReviewId = "R02",
                   Stars = 3,
                   Text = "Jeg kan godt lide Hurtig-mad. Det kunne dog have været hurtigere",
               });
            modelBuilder.Entity<Review>()
               .HasData(new Review()
               {
                   ReviewId = "R03",
                   Stars = 5,
                   Text = "Jeg elsker Hurtig-mad. Det var bare lyn-hurtigt! :)",
               });


            //Data seeding Review
            modelBuilder.Entity<Dish>()
              .HasData(new Dish()
              {
                  DishId = "1334",
                  Price = 9.95,
                  DishName = "Cheese Burger",
                  Type = "Coin Offer",
              });
            modelBuilder.Entity<Dish>()
              .HasData(new Dish()
              {
                  DishId = "1335",
                  Price = 36.95,
                  DishName = "Happy Meal",
                  Type = "Børne Menu",
              });

            modelBuilder.Entity<Dish>()
             .HasData(new Dish()
             {
                 DishId = "1336",
                 Price = 14.95,
                 DishName = "Whopper",
                 Type = "Langsom burger",
             });
            modelBuilder.Entity<Dish>()
            .HasData(new Dish()
            {
                DishId = "1337",
                Price = 29.95,
                DishName = "Double-Whopper",
                Type = "Lidt hurtigere burger",
            });

            //Waiter
            //Data seeding 
            modelBuilder.Entity<Waiter>()
             .HasData(new Waiter()
             {
                 WaiterId = "8005",
                 Salary = 2500,
             });
            modelBuilder.Entity<Waiter>()
             .HasData(new Waiter()
             {
                 WaiterId = "8006",
                 Salary = 2600,
             });
            modelBuilder.Entity<Waiter>()
             .HasData(new Waiter()
             {
                 WaiterId = "8007",
                 Salary = 2700,
             });
            modelBuilder.Entity<Waiter>()
             .HasData(new Waiter()
             {
                 WaiterId = "8008",
                 Salary = 2800,
             });


            //Data seeding Guest
            modelBuilder.Entity<Guest>()
              .HasData(new Guest()
              {
                  GuestId = "417",
                  Time = new DateTime(2019, 6, 10),
              });
            modelBuilder.Entity<Guest>()
              .HasData(new Guest()
              {
                  GuestId = "418",
                  Time = new DateTime(2019, 7, 10),
              });
            modelBuilder.Entity<Guest>()
              .HasData(new Guest()
              {
                  GuestId = "419",
                  Time = new DateTime(2019, 8, 10),
              });
            modelBuilder.Entity<Guest>()
              .HasData(new Guest()
              {
                  GuestId = "420",
                  Time = new DateTime(2019, 9, 10),
              });


            //Data seeding Person
            modelBuilder.Entity<Person>()
              .HasData(new Person()
              {
                  PersonId = "61",
                  Name = "Jeps Jepsemand",
              });
            modelBuilder.Entity<Person>()
              .HasData(new Person()
              {
                  PersonId = "62",
                  Name = "Jobs Jobsemand",
              });
            modelBuilder.Entity<Person>()
              .HasData(new Person()
              {
                  PersonId = "63",
                  Name = "Flobs Flobsemand",
              });
            modelBuilder.Entity<Person>()
              .HasData(new Person()
              {
                  PersonId = "64",
                  Name = "Muubs Megetsyg",
              });
            modelBuilder.Entity<Person>()
              .HasData(new Person()
              {
                  PersonId = "65",
                  Name = "Blobs Blobbermand",
              });
            modelBuilder.Entity<Person>()
              .HasData(new Person()
              {
                  PersonId = "67",
                  Name = "Djebs Djakketyv",
              });
            modelBuilder.Entity<Person>()
              .HasData(new Person()
              {
                  PersonId = "68",
                  Name = "Henrik DABsemand",
              });
            modelBuilder.Entity<Person>()
              .HasData(new Person()
              {
                  PersonId = "69",
                  Name = "Jørgen Ingenarm",
              });
        }
    }
}
