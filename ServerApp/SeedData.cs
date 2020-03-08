﻿using Microsoft.EntityFrameworkCore;
using ServerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();
            if (context.Products.Count() == 0)
            {
                var s1 = new Supplier
                {
                    Name = "Splash Dudes",
                    City = "San Jose",
                    State = "CA"
                };
                var s2 = new Supplier
                {
                    Name = "Soccer Town",
                    City = "Chicago",
                    State = "IL"
                };
                var s3 = new Supplier
                {
                    Name = "Chess Co",
                    City = "New York",
                    State = "NY"
                };
                var s4 = new Supplier
                {
                    Name = "Texas Outdoors",
                    City = "Austin",
                    State = "TX"
                };
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275,
                        Supplier = s1,
                        Ratings = new List<Rating> {
                             new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                    },
                     new Product
                     {
                         Name = "Lifejacket",
                         Description = "Protective and fashionable",
                         Category = "Watersports",
                         Price = 48.95m,
                         Supplier = s1,
                         Ratings = new List<Rating> {
                             new Rating { Stars = 2 }, new Rating { Stars = 5 }}
                     },
                     new Product
                     {
                         Name = "Soccer Ball",
                         Description = "FIFA-approved size and weight",
                         Category = "Soccer",
                         Price = 19.50m,
                         Supplier = s2,
                         Ratings = new List<Rating> {
                             new Rating { Stars = 1 }, new Rating { Stars = 3 }}
                     },
                     new Product
                     {
                         Name = "Corner Flags",
                         Description = "Give your pitch a professional touch",
                         Category = "Soccer",
                         Price = 34.95m,
                         Supplier = s2,
                         Ratings = new List<Rating> { new Rating { Stars = 3 } }
                     },
                     new Product
                     {
                         Name = "Stadium",
                         Description = "Flat-packed 35,000-seat stadium",
                         Category = "Soccer",
                         Price = 79500,
                         Supplier = s2,
                         Ratings = new List<Rating> { new Rating { Stars = 1 },
                             new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                     },
                     new Product
                     {
                         Name = "Thinking Cap",
                         Description = "Improve brain efficiency by 75%",
                         Category = "Chess",
                         Price = 16,
                         Supplier = s3,
                         Ratings = new List<Rating> { new Rating { Stars = 5 },
                             new Rating { Stars = 4 }}
                     },
                     new Product
                     {
                         Name = "Unsteady Chair",
                         Description = "Secretly give your opponent a disadvantage",
                         Category = "Chess",
                         Price = 29.95m,
                         Supplier = s3,
                         Ratings = new List<Rating> { new Rating { Stars = 3 } }
                     },
                     new Product
                     {
                         Name = "Human Chess Board",
                         Description = "A fun game for the family",
                         Category = "Chess",
                         Price = 75,
                         Supplier = s3
                     },
                     new Product
                     {
                         Name = "Bling-Bling King",
                         Description = "Gold-plated, diamond-studded King",
                         Category = "Chess",
                         Price = 1200,
                         Supplier = s3
                     },
                     new Product
                     {
                         Name = "Fiberglass Fishing Rod",
                         Description = "Fishing Rod",
                         Category = "Outdoors",
                         Price = 12.07m,
                         Supplier = s4,
                         Ratings = new List<Rating> { new Rating { Stars = 4 } }
                     },
                     new Product
                     {
                         Name = "Reel",
                         Description = "Reel",
                         Category = "Outdoors",
                         Price = 11.95m,
                         Supplier = s4,
                         Ratings = new List<Rating> { new Rating { Stars = 3 } }
                     },
                     new Product
                     {
                         Name = "Fiberglass Paddle",
                         Description = "Paddle",
                         Category = "Outdoors",
                         Price = 54.39m,
                         Supplier = s4
                     },
                     new Product
                     {
                         Name = "Sunscreen",
                         Description = "Sun screen",
                         Category = "Outdoors",
                         Price = 4.17m,
                         Supplier = s4
                     },
                     new Product
                     {
                         Name = "Fiberglass Fishing Rod",
                         Description = "Fishing Rod",
                         Category = "Outdoors",
                         Price = 12.07m,
                         Supplier = s4,
                         Ratings = new List<Rating> { new Rating { Stars = 4 } }
                     },
                     new Product
                     {
                         Name = "Reel",
                         Description = "Reel",
                         Category = "Outdoors",
                         Price = 11.83m,
                         Supplier = s4,
                         Ratings = new List<Rating> { new Rating { Stars = 3 } }
                     },
                     new Product
                     {
                         Name = "Fiberglass Paddle",
                         Description = "Paddle",
                         Category = "Outdoors",
                         Price = 54.39m,
                         Supplier = s4
                     },
                     new Product
                     {
                         Name = "Sunscreen",
                         Description = "Sun screen",
                         Category = "Outdoors",
                         Price = 4.17m,
                         Supplier = s4,
                         Ratings = new List<Rating> { new Rating { Stars = 1 },
                             new Rating { Stars = 4 }, new Rating { Stars = 3 }}
                     });
                context.SaveChanges();
            }
        }
    }
}
