// Purpose: Seeds Alums & categories to their respective tables in db

/*****************************************************************/
/* If seeded data is no longer required this file can be deleted */
/*****************************************************************/

using System;
using System.Linq;
using Trasalum.Data;
using Trasalum.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Trasalum
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider, UserManager<ApplicationUser> userManager)
        {
            var context = serviceProvider.GetRequiredService<ApplicationDbContext>();

            context.Database.EnsureCreated();

            /**************************/
            /* Seeding Cohort Table */
            /**************************/
            if (!context.Cohort.Any())
            {
                context.Cohort.Add(new Cohort
                {
                    Number = "C1",
                    StartDate = DateTime.Now.AddDays(-540),
                    DemoDate = DateTime.Now.AddDays(-360)
                });
                context.Cohort.Add(new Cohort
                {
                    Number = "E1",
                    StartDate = DateTime.Now.AddDays(-360),
                    DemoDate = DateTime.Now.AddDays(-180)
                });
                context.Cohort.Add(new Cohort
                {
                    Number = "C2",
                    StartDate = DateTime.Now.AddDays(-180),
                    DemoDate = DateTime.Now.AddDays(-1)
                });
                context.SaveChanges();
            }

            /*************************/
            /* Seeding Alum Table */
            /*************************/
            /*if (!context.Alum.Any())
            {
                context.Alum.Add(new Alum
                {
                    FirstName = "John",
                    LastName = "Smith",
                    CohortId = 1,
                    Address = "1 Main St.",
                    Address2 = "Apt A-1",
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37201",
                    Phone = "615-222-3344",
                    Email = "jsmith@email.com",
                    GitHub = "john-smith",
                    LinkedIn = "john-smith",
                    Slack = "john-smith"
                });

                /*context.Alum.Add(new Alum
                {
                    User = user1,
                    Name = "Knit Scarf",
                    Description = "A beautifully knitted scarf for a toddler girl.",
                    CohortId = AlumCohortId,
                    Status = true,
                    Price = 25.00,
                    DateCreated = DateTime.Now,
                    Quantity = 4,
                    Photo = "",
                    City = "Nashville",
                    State = "TN",
                    DeliverLocal = false,
                });

                context.Alum.Add(new Alum
                {
                    User = user1,
                    Name = "Knit Mittens",
                    Description = "Beautifully knitted mittens for a toddler girl.",
                    CohortId = AlumCohortId,
                    Status = true,
                    Price = 25.00,
                    DateCreated = DateTime.Now,
                    Quantity = 3,
                    Photo = "",
                    City = "Nashville",
                    State = "TN",
                    DeliverLocal = false,
                });

                AlumCohortId = (from ct in context.Cohort
                                     where ct.CohortType.Equals("Jewelry & Accessories")
                                     select ct.Id).Single();

                context.Alum.Add(new Alum
                {
                    User = user1,
                    Name = "Beaded Bracelet",
                    Description = "A beautiful handmade beaded bracelet.",
                    CohortId = AlumCohortId,
                    Status = true,
                    Price = 28.50,
                    DateCreated = DateTime.Now,
                    Quantity = 6,
                    Photo = "",
                    City = "Nashville",
                    State = "TN",
                    DeliverLocal = false,
                });

                context.Alum.Add(new Alum
                {
                    User = user1,
                    Name = "Charm Bracelet",
                    Description = "A beautiful handmade charm bracelet.",
                    CohortId = AlumCohortId,
                    Status = true,
                    Price = 42.00,
                    DateCreated = DateTime.Now,
                    Quantity = 3,
                    Photo = "",
                    City = "Nashville",
                    State = "TN",
                    DeliverLocal = false,
                });

                ApplicationUser user2 = userManager.FindByNameAsync("jdoe@email.com").Result;

                AlumCohortId = (from ct in context.Cohort
                                     where ct.CohortType.Equals("Arts & Collectibles")
                                     select ct.Id).Single();

                context.Alum.Add(new Alum
                {
                    User = user2,
                    Name = "Sunset Painting",
                    Description = "A beautiful oil painting of a beach during sunset.",
                    CohortId = AlumCohortId,
                    Status = true,
                    Price = 225.00,
                    DateCreated = DateTime.Now,
                    Quantity = 1,
                    Photo = "",
                    City = "Nashville",
                    State = "TN",
                    DeliverLocal = false,
                });

                context.Alum.Add(new Alum
                {
                    User = user2,
                    Name = "Paris Cafe Painting",
                    Description = "A beautiful oil painting a cafe in Paris.",
                    CohortId = AlumCohortId,
                    Status = true,
                    Price = 350.00,
                    DateCreated = DateTime.Now,
                    Quantity = 1,
                    Photo = "",
                    City = "Nashville",
                    State = "TN",
                    DeliverLocal = false,
                });

                AlumCohortId = (from ct in context.Cohort
                                     where ct.CohortType.Equals("Home & Living")
                                     select ct.Id).Single();

                context.Alum.Add(new Alum
                {
                    User = user2,
                    Name = "Handmade Quilt",
                    Description = "A very warm beautifully hand crafted quilt.",
                    CohortId = AlumCohortId,
                    Status = true,
                    Price = 155.25,
                    DateCreated = DateTime.Now,
                    Quantity = 1,
                    Photo = "",
                    City = "Nashville",
                    State = "TN",
                    DeliverLocal = false,
                });

                context.SaveChanges();
            }*/
            
            /******************************/
            /* Seeding Payment Type Table */
            /******************************/
            /*
            if (!context.PaymentType.Any())
            {
                ApplicationUser user1 = userManager.FindByNameAsync("jsmith@email.com").Result;

                //payment on a completed order
                context.PaymentType.Add(new PaymentType
                {
                    User = user1,
                    Name = "Payment 1",
                    AccountNumber = "18203948",
                    Active = true
                });
                //payment not on any order
                context.PaymentType.Add(new PaymentType
                {
                    User = user1,
                    Name = "Payment 2",
                    AccountNumber = "29384059",
                    Active = true
                });
                //payment not on any order
                context.PaymentType.Add(new PaymentType
                {
                    User = user1,
                    Name = "Payment 3",
                    AccountNumber = "37485968",
                    Active = true
                });

                context.SaveChanges();

            }
            */
            /****************************/
            /* Seeding Order Type Table */
            /****************************/
            /*if (!context.Order.Any())
            {
                ApplicationUser user1 = userManager.FindByNameAsync("jsmith@email.com").Result;
                int payment1Id = (from p in context.PaymentType
                                  where p.Name.Equals("Payment 1")
                                  select p.Id).Single();
                PaymentType payment1 = context.PaymentType.Where(p => p.Id == payment1Id).Single();

                //completed order
                context.Order.Add(new Order
                {
                    User = user1,
                    PaymentId = payment1Id,
                    PaymentType = payment1,
                    DateCreated = DateTime.Now.AddDays(-100),
                    DateClosed = DateTime.Now.AddDays(-99)
                });
                //incomplete order
                context.Order.Add(new Order
                {
                    User = user1,
                    DateCreated = DateTime.Now.AddDays(-10),
                });

                context.SaveChanges();

            }*/
            /***********************************/
            /* Seeding OrderAlum Type Table */
            /***********************************/
            /*if (!context.OrderAlum.Any())
            {
                ApplicationUser user1 = userManager.FindByNameAsync("jsmith@email.com").Result;
                int payment1Id = (from p in context.PaymentType
                                  where p.Name.Equals("Payment 1")
                                  select p.Id).Single();
                int order1Id = (from o in context.Order
                                where o.User.Equals(user1) && o.PaymentId.Equals(payment1Id)
                                select o.Id).Single();
                int order2Id = (from o in context.Order
                                where o.User.Equals(user1) && o.PaymentId == null
                                select o.Id).Single();
                int Alum1Id = (from p in context.Alum
                                  where p.Name.Equals("Sunset Painting")
                                  select p.Id).Single();
                int Alum2Id = (from p in context.Alum
                                  where p.Name.Equals("Paris Cafe Painting")
                                  select p.Id).Single();

                //Alum on completed order
                context.OrderAlum.Add(new OrderAlum
                {
                    OrderId = order1Id,
                    AlumId = Alum1Id
                });
                //Alum on incomplete order
                context.OrderAlum.Add(new OrderAlum
                {
                    OrderId = order2Id,
                    AlumId = Alum2Id
                });

                context.SaveChanges();

            }*/
        }
    }
}