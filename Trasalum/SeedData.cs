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
using Microsoft.EntityFrameworkCore;

namespace Trasalum
{
    public static class SeedData
    {
        public async static void Initialize(IServiceProvider serviceProvider, UserManager<ApplicationUser> userManager)
        {
            var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>());

            /************************/
            /* Seeding Cohort Table */
            /************************/
            if (!context.Cohort.Any())
            {
                context.Cohort.Add(new Cohort
                {
                    Number = "C1",
                    StartDate = DateTime.ParseExact("01/06/2012 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("30/11/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C2",
                    StartDate = DateTime.ParseExact("01/01/2013 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("30/06/2013 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C3",
                    StartDate = DateTime.ParseExact("01/09/2013 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("30/03/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C4",
                    StartDate = DateTime.ParseExact("04/01/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("22/06/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C5",
                    StartDate = DateTime.ParseExact("05/04/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("24/09/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C6",
                    StartDate = DateTime.ParseExact("05/07/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("13/01/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C7",
                    StartDate = DateTime.ParseExact("03/09/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("24/03/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C8",
                    StartDate = DateTime.ParseExact("04/01/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/06/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "E1",
                    StartDate = DateTime.ParseExact("06/02/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("12/01/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C9",
                    StartDate = DateTime.ParseExact("06/04/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("25/09/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C10",
                    StartDate = DateTime.ParseExact("06/07/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("12/01/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "E2",
                    StartDate = DateTime.ParseExact("06/07/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/06/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C11",
                    StartDate = DateTime.ParseExact("05/10/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("25/03/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "E3",
                    StartDate = DateTime.ParseExact("03/01/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("10/01/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C12",
                    StartDate = DateTime.ParseExact("02/01/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/06/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C13",
                    StartDate = DateTime.ParseExact("04/04/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/09/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C14",
                    StartDate = DateTime.ParseExact("14/05/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("04/11/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C15",
                    StartDate = DateTime.ParseExact("05/07/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("10/01/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "E4",
                    StartDate = DateTime.ParseExact("05/07/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/06/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C16",
                    StartDate = DateTime.ParseExact("03/10/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("24/03/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C17",
                    StartDate = DateTime.ParseExact("14/11/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("19/05/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C18",
                    StartDate = DateTime.ParseExact("03/01/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/06/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "E5",
                    StartDate = DateTime.ParseExact("03/01/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("09/01/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C19",
                    StartDate = DateTime.ParseExact("03/04/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("22/09/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C20",
                    StartDate = DateTime.ParseExact("22/05/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("10/11/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C21",
                    StartDate = DateTime.ParseExact("05/07/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("09/01/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "E6",
                    StartDate = DateTime.ParseExact("05/07/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("22/06/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C22",
                    StartDate = DateTime.ParseExact("02/10/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/03/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C23",
                    StartDate = DateTime.ParseExact("13/11/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("18/05/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C24",
                    StartDate = DateTime.ParseExact("02/01/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("22/06/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Number = "C25",
                    StartDate = DateTime.ParseExact("02/04/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("21/09/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
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

            /***************************************/
            /* Seeding ASP.NET ROLES Table         */
            /* Provides roles for ApplicationUsers */
            /***************************************/
            var roleStore = new RoleStore<IdentityRole>(context);
            var userstore = new UserStore<ApplicationUser>(context);

            if (!context.Roles.Any(r => r.Name == "Educator"))
            {
                var role = new IdentityRole { Name = "Educator", NormalizedName = "Educator" };
                await roleStore.CreateAsync(role);
            }
            if (!context.Roles.Any(r => r.Name == "Operations"))
            {
                var role = new IdentityRole { Name = "Operations", NormalizedName = "Operations" };
                await roleStore.CreateAsync(role);
            }

            /*********************************/
            /* Seeding ApplicationUser Table */
            /*********************************/
            if (!context.ApplicationUser.Any(u => u.Email == "steve@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Steve",
                    LastName = "Brownlee",
                    CurrentEmploy = true,
                    UserName = "steve@email.com",
                    NormalizedUserName = "steve@email.com",
                    Email = "steve@email.com",
                    NormalizedEmail = "STEVE@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }
            if (!context.ApplicationUser.Any(u => u.Email == "greg@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Greg",
                    LastName = "Korte",
                    CurrentEmploy = true,
                    UserName = "greg@email.com",
                    NormalizedUserName = "GREG@EMAIL>COM",
                    Email = "greg@email.com",
                    NormalizedEmail = "GREG@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }
            if (!context.ApplicationUser.Any(u => u.Email == "hannah@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Hannah",
                    LastName = "Hall",
                    CurrentEmploy = true,
                    UserName = "hannah@email.com",
                    NormalizedUserName = "HANNAH@EMAIL.COM",
                    Email = "hannah@email.com",
                    NormalizedEmail = "HANNAH@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }
            if (!context.ApplicationUser.Any(u => u.Email == "eliza@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Eliza",
                    LastName = "Brock",
                    CurrentEmploy = true,
                    UserName = "eliza@email.com",
                    NormalizedUserName = "eliza@email.com",
                    Email = "eliza@email.com",
                    NormalizedEmail = "ELIZA@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "john@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "John",
                    LastName = "Wark",
                    CurrentEmploy = true,
                    UserName = "john@email.com",
                    NormalizedUserName = "john@email.com",
                    Email = "john@email.com",
                    NormalizedEmail = "JOHN@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "adam@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Adam",
                    LastName = "Scott",
                    CurrentEmploy = true,
                    UserName = "adam@email.com",
                    NormalizedUserName = "adam@email.com",
                    Email = "adam@email.com",
                    NormalizedEmail = "ADAM@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "chyld@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Chyld",
                    LastName = "Medford",
                    CurrentEmploy = true,
                    UserName = "chyld@email.com",
                    NormalizedUserName = "chyld@email.com",
                    Email = "chyld@email.com",
                    NormalizedEmail = "chyld@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "scott@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Scott",
                    LastName = "Humphries",
                    CurrentEmploy = true,
                    UserName = "scott@email.com",
                    NormalizedUserName = "scott@email.com",
                    Email = "scott@email.com",
                    NormalizedEmail = "SCOTT@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "jurnell@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Jurnell",
                    LastName = "Cockhren",
                    CurrentEmploy = true,
                    UserName = "jurnell@email.com",
                    NormalizedUserName = "jurnell@email.com",
                    Email = "jurnell@email.com",
                    NormalizedEmail = "JURNELL@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "joe@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Joe",
                    LastName = "Shepherd",
                    CurrentEmploy = true,
                    UserName = "joe@email.com",
                    NormalizedUserName = "joe@email.com",
                    Email = "joe@email.com",
                    NormalizedEmail = "JOE@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "zoe@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Zoe",
                    LastName = "Ames",
                    CurrentEmploy = true,
                    UserName = "zoe@email.com",
                    NormalizedUserName = "zoe@email.com",
                    Email = "zoe@email.com",
                    NormalizedEmail = "ZOE@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "denise@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Denise",
                    LastName = "Tinsley",
                    CurrentEmploy = true,
                    UserName = "denise@email.com",
                    NormalizedUserName = "denise@email.com",
                    Email = "denise@email.com",
                    NormalizedEmail = "DENISE@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "caitlyn@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Caitlyn",
                    LastName = "Stein",
                    CurrentEmploy = true,
                    UserName = "caitlyn@email.com",
                    NormalizedUserName = "caitlyn@email.com",
                    Email = "caitlyn@email.com",
                    NormalizedEmail = "CAITLYN@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "callan@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Callan",
                    LastName = "Callan",
                    CurrentEmploy = true,
                    UserName = "callan@email.com",
                    NormalizedUserName = "callan@email.com",
                    Email = "callan@email.com",
                    NormalizedEmail = "CALLAN@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "nathan@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Nathan",
                    LastName = "Gonzalez",
                    CurrentEmploy = true,
                    UserName = "nathan@email.com",
                    NormalizedUserName = "nathan@email.com",
                    Email = "nathan@email.com",
                    NormalizedEmail = "NATHAN@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "brenda@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Brenda",
                    LastName = "Long",
                    CurrentEmploy = true,
                    UserName = "brenda@email.com",
                    NormalizedUserName = "brenda@email.com",
                    Email = "brenda@email.com",
                    NormalizedEmail = "BRENDA@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }

            if (!context.ApplicationUser.Any(u => u.Email == "eliza@email.com"))
            {
                //  This method will be called after migrating to the latest version.
                ApplicationUser user = new ApplicationUser
                {
                    FirstName = "Eliza",
                    LastName = "Brock",
                    CurrentEmploy = true,
                    UserName = "eliza@email.com",
                    NormalizedUserName = "eliza@email.com",
                    Email = "eliza@email.com",
                    NormalizedEmail = "ELIZA@EMAIL.COM",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString("D")
                };
                var passwordHash = new PasswordHasher<ApplicationUser>();
                user.PasswordHash = passwordHash.HashPassword(user, "password");
                await userstore.CreateAsync(user);
                await userstore.AddToRoleAsync(user, "Educator");
            }
            /**************************/
            /* Seeding TechType Table */
            /**************************/
            if (!context.TechType.Any())
            {
                context.TechType.Add(new TechType
                {
                    Name = "Language",
                });
                context.TechType.Add(new TechType
                {
                    Name = "Framework",
                });
                context.TechType.Add(new TechType
                {
                    Name = "Tool",
                });
                context.TechType.Add(new TechType
                {
                    Name = "Process",
                });

                context.SaveChanges();
            }

            /**********************/
            /* Seeding Tech Table */
            /**********************/
            if (!context.Tech.Any())
            {
                int language = (from tt in context.TechType
                          where tt.Name.Equals("Language")
                          select tt.Id).Single();
                int framework = (from tt in context.TechType
                                where tt.Name.Equals("Framework")
                                select tt.Id).Single();
                int tool = (from tt in context.TechType
                                where tt.Name.Equals("Tool")
                                select tt.Id).Single();
                int process = (from tt in context.TechType
                                where tt.Name.Equals("Process")
                                select tt.Id).Single();

                context.Tech.Add(new Tech
                {
                    Name = "HTML",
                    TechTypeId = language
                });
                context.Tech.Add(new Tech
                {
                    Name = "JavaScript",
                    TechTypeId = language
                });
                context.Tech.Add(new Tech
                {
                    Name = "CSS",
                    TechTypeId = language
                });
                context.Tech.Add(new Tech
                {
                    Name = "C#",
                    TechTypeId = language
                });
                context.Tech.Add(new Tech
                {
                    Name = "Ruby on Rails",
                    TechTypeId = language
                });
                context.Tech.Add(new Tech
                {
                    Name = "Python",
                    TechTypeId = language
                });
                context.Tech.Add(new Tech
                {
                    Name = "Git",
                    TechTypeId = tool
                });
                context.Tech.Add(new Tech
                {
                    Name = ".NET",
                    TechTypeId = framework
                });
                context.Tech.Add(new Tech
                {
                    Name = "GitHub",
                    TechTypeId = tool
                });
                context.Tech.Add(new Tech
                {
                    Name = "ASP.NET",
                    TechTypeId = framework
                });
                context.Tech.Add(new Tech
                {
                    Name = "SASS",
                    TechTypeId = framework
                });
                context.Tech.Add(new Tech
                {
                    Name = "Visual Studio",
                    TechTypeId = tool
                });
                context.Tech.Add(new Tech
                {
                    Name = "Visual Studio Code",
                    TechTypeId = tool
                });
                context.Tech.Add(new Tech
                {
                    Name = "SCRUM",
                    TechTypeId = process
                });
                context.Tech.Add(new Tech
                {
                    Name = "Kanban",
                    TechTypeId = process
                });
                context.Tech.Add(new Tech
                {
                    Name = "Agile",
                    TechTypeId = process
                });
                context.Tech.Add(new Tech
                {
                    Name = "Firebase",
                    TechTypeId = tool
                });
                context.Tech.Add(new Tech
                {
                    Name = "SQL Server",
                    TechTypeId = tool
                });
                context.Tech.Add(new Tech
                {
                    Name = "SQLLite",
                    TechTypeId = tool
                });
                context.Tech.Add(new Tech
                {
                    Name = "Node.JS",
                    TechTypeId = language
                });
                context.Tech.Add(new Tech
                {
                    Name = "Django",
                    TechTypeId = framework
                });
                context.Tech.Add(new Tech
                {
                    Name = "Angular.JS",
                    TechTypeId = framework
                });
                context.Tech.Add(new Tech
                {
                    Name = "General/Non-Specific"
                });
                context.Tech.Add(new Tech
                {
                    Name = "Unknown"
                });
                context.Tech.Add(new Tech
                {
                    Name = "N/A"
                });

                context.SaveChanges();
            }

            /*****************************/
            /* Seeding CohortStaff Table */
            /*****************************/
            /*
            if (!context.CohortStaff.Any())
            {
                ApplicationUser john = userManager.FindByNameAsync("john@email.com").Result;
                ApplicationUser eliza = userManager.FindByNameAsync("eliza@email.com").Result;
                ApplicationUser adam = userManager.FindByNameAsync("adam@email.com").Result;
                ApplicationUser chyld = userManager.FindByNameAsync("chyld@email.com").Result;
                ApplicationUser scott = userManager.FindByNameAsync("scott@email.com").Result;
                ApplicationUser jurnell = userManager.FindByNameAsync("jurnell@email.com").Result;
                ApplicationUser steve = userManager.FindByNameAsync("steve@email.com").Result;
                ApplicationUser joe = userManager.FindByNameAsync("joe@email.com").Result;
                ApplicationUser zoe = userManager.FindByNameAsync("zoe@email.com").Result;
                ApplicationUser denise = userManager.FindByNameAsync("denise@email.com").Result;
                ApplicationUser caitlyn = userManager.FindByNameAsync("caitlyn@email.com").Result;
                ApplicationUser greg = userManager.FindByNameAsync("greg@email.com").Result;
                ApplicationUser nathan = userManager.FindByNameAsync("nathan@email.com").Result;
                ApplicationUser brenda = userManager.FindByNameAsync("brenda@email.com").Result;
                ApplicationUser callan = userManager.FindByNameAsync("callan@email.com").Result;
                int c1 = (from c in context.Cohort
                          where c.Number.Equals("C1")
                          select c.Id).Single();
                int c2 = (from c in context.Cohort
                          where c.Number.Equals("C2")
                          select c.Id).Single();
                int c3 = (from c in context.Cohort
                          where c.Number.Equals("C3")
                          select c.Id).Single();
                int c4 = (from c in context.Cohort
                          where c.Number.Equals("C4")
                          select c.Id).Single();
                int c5 = (from c in context.Cohort
                          where c.Number.Equals("C5")
                          select c.Id).Single();
                int c6 = (from c in context.Cohort
                          where c.Number.Equals("C6")
                          select c.Id).Single();
                int c7 = (from c in context.Cohort
                          where c.Number.Equals("C7")
                          select c.Id).Single();
                int c8 = (from c in context.Cohort
                          where c.Number.Equals("C8")
                          select c.Id).Single();
                int c9 = (from c in context.Cohort
                          where c.Number.Equals("C9")
                          select c.Id).Single();
                int c10 = (from c in context.Cohort
                           where c.Number.Equals("C10")
                           select c.Id).Single();
                int c11 = (from c in context.Cohort
                           where c.Number.Equals("C11")
                           select c.Id).Single();
                int c12 = (from c in context.Cohort
                           where c.Number.Equals("C12")
                           select c.Id).Single();
                int c13 = (from c in context.Cohort
                           where c.Number.Equals("C13")
                           select c.Id).Single();
                int c14 = (from c in context.Cohort
                           where c.Number.Equals("C14")
                           select c.Id).Single();
                int c15 = (from c in context.Cohort
                           where c.Number.Equals("C15")
                           select c.Id).Single();
                int c16 = (from c in context.Cohort
                           where c.Number.Equals("C16")
                           select c.Id).Single();
                int c17 = (from c in context.Cohort
                           where c.Number.Equals("C17")
                           select c.Id).Single();
                int c18 = (from c in context.Cohort
                           where c.Number.Equals("C18")
                           select c.Id).Single();
                int c19 = (from c in context.Cohort
                           where c.Number.Equals("C19")
                           select c.Id).Single();
                int c20 = (from c in context.Cohort
                           where c.Number.Equals("C20")
                           select c.Id).Single();
                int c21 = (from c in context.Cohort
                           where c.Number.Equals("C21")
                           select c.Id).Single();
                int c22 = (from c in context.Cohort
                           where c.Number.Equals("C22")
                           select c.Id).Single();
                int c23 = (from c in context.Cohort
                           where c.Number.Equals("C23")
                           select c.Id).Single();
                int c24 = (from c in context.Cohort
                           where c.Number.Equals("C24")
                           select c.Id).Single();
                int c25 = (from c in context.Cohort
                           where c.Number.Equals("C25")
                           select c.Id).Single();
                int e1 = (from c in context.Cohort
                          where c.Number.Equals("E1")
                          select c.Id).Single();
                int e2 = (from c in context.Cohort
                          where c.Number.Equals("E2")
                          select c.Id).Single();
                int e3 = (from c in context.Cohort
                          where c.Number.Equals("E3")
                          select c.Id).Single();
                int e4 = (from c in context.Cohort
                          where c.Number.Equals("E4")
                          select c.Id).Single();
                int e5 = (from c in context.Cohort
                          where c.Number.Equals("E5")
                          select c.Id).Single();
                int e6 = (from c in context.Cohort
                          where c.Number.Equals("E6")
                          select c.Id).Single();

                //c1
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c1,
                    StaffId = john
                });
                //c1
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c1,
                    StaffId = eliza
                });
                //c2
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c2,
                    StaffId = adam
                });
                //c2
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c2,
                    StaffId = eliza
                });
                //c2
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c2,
                    StaffId = john
                });
                //c3
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c3,
                    StaffId = eliza
                });
                //c3
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c3,
                    StaffId = chyld
                });
                //c4
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c4,
                    StaffId = chyld
                });
                //c4
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c4,
                    StaffId = eliza
                });
                //c5
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c5,
                    StaffId = chyld
                });
                //c5
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c5,
                    StaffId = eliza
                });
                //c6
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c6,
                    StaffId = chyld
                });
                //c7
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c7,
                    StaffId = eliza
                });
                //c7
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c7,
                    StaffId = scott
                });
                //c7
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c7,
                    StaffId = jurnell
                });
                //c8
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c8,
                    StaffId = eliza
                });
                //c8
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c8,
                    StaffId = scott
                });
                //c8
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c8,
                    StaffId = jurnell
                });
                //c9
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c9,
                    StaffId = scott
                });
                //c10
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c10,
                    StaffId = eliza
                });
                //c10
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c10,
                    StaffId = steve
                });
                //c10
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c10,
                    StaffId = jurnell
                });
                //c11
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c11,
                    StaffId = steve
                });
                //c11
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c11,
                    StaffId = scott
                });
                //c12
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c12,
                    StaffId = caitlyn
                });
                //c12
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c12,
                    StaffId = denise
                });
                //c12
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c12,
                    StaffId = steve
                });
                //c12
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c12,
                    StaffId = joe
                });
                //c13
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c13,
                    StaffId = joe
                });
                //c13
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c13,
                    StaffId = scott
                });
                //c13
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c13,
                    StaffId = steve
                });
                //c14
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c14,
                    StaffId = joe
                });
                //c14
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c14,
                    StaffId = scott
                });
                //c14
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c14,
                    StaffId = callan
                });
                //c15
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c15,
                    StaffId = caitlyn
                });
                //c15
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c15,
                    StaffId = joe
                });
                //c15
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c15,
                    StaffId = scott
                });
                //c15
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c15,
                    StaffId = denise
                });
                //c15
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c15,
                    StaffId = greg
                });
                //c16
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c16,
                    StaffId = brenda
                });
                //c16
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c16,
                    StaffId = joe
                });
                //c16
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c16,
                    StaffId = steve
                });
                //c17
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c17,
                    StaffId = joe
                });
                //c17
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c17,
                    StaffId = scott
                });
                //c18
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c18,
                    StaffId = brenda
                });
                //c18
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c18,
                    StaffId = steve
                });
                //c19
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c19,
                    StaffId = brenda
                });
                //c19
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c19,
                    StaffId = steve
                });
                //c20
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c20,
                    StaffId = joe
                });
                //c21
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c21,
                    StaffId = brenda
                });
                //c21
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c21,
                    StaffId = steve
                });
                //c22
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c22,
                    StaffId = steve
                });
                //c23
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c23,
                    StaffId = joe
                });
                //c24
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c24,
                    StaffId = brenda
                });
                //c25
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c25,
                    StaffId = steve
                });

                //e1
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e1,
                    StaffId = steve
                });
                //e1
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e1,
                    StaffId = jurnell
                });
                //e2
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e2,
                    StaffId = steve
                });
                //e2
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e2,
                    StaffId = jurnell
                });
                //e2
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e2,
                    StaffId = joe
                });
                //e3
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e3,
                    StaffId = zoe
                });
                //e3
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e3,
                    StaffId = jurnell
                });
                //e3
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e3,
                    StaffId = joe
                });
                //e4
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e4,
                    StaffId = zoe
                });
                //e4
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e4,
                    StaffId = jurnell
                });
                //e4
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e4,
                    StaffId = nathan
                });
                //e5
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e5,
                    StaffId = zoe
                });
                //e5
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e5,
                    StaffId = jurnell
                });
                //e6
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e6,
                    StaffId = zoe
                });
                //e6
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e6,
                    StaffId = jurnell
                });

                context.SaveChanges();
            }
            */
            /*****************************/
            /* Seeding CohortTech Table */
            /*****************************/
            if (!context.CohortTech.Any())
            {
                int c1 = (from c in context.Cohort
                          where c.Number.Equals("C1")
                          select c.Id).Single();
                int c2 = (from c in context.Cohort
                          where c.Number.Equals("C2")
                          select c.Id).Single();
                int c3 = (from c in context.Cohort
                          where c.Number.Equals("C3")
                          select c.Id).Single();
                int c4 = (from c in context.Cohort
                          where c.Number.Equals("C4")
                          select c.Id).Single();
                int c5 = (from c in context.Cohort
                          where c.Number.Equals("C5")
                          select c.Id).Single();
                int c6 = (from c in context.Cohort
                          where c.Number.Equals("C6")
                          select c.Id).Single();
                int c7 = (from c in context.Cohort
                          where c.Number.Equals("C7")
                          select c.Id).Single();
                int c8 = (from c in context.Cohort
                          where c.Number.Equals("C8")
                          select c.Id).Single();
                int c9 = (from c in context.Cohort
                          where c.Number.Equals("C9")
                          select c.Id).Single();
                int c10 = (from c in context.Cohort
                           where c.Number.Equals("C10")
                           select c.Id).Single();
                int c11 = (from c in context.Cohort
                           where c.Number.Equals("C11")
                           select c.Id).Single();
                int c12 = (from c in context.Cohort
                           where c.Number.Equals("C12")
                           select c.Id).Single();
                int c13 = (from c in context.Cohort
                           where c.Number.Equals("C13")
                           select c.Id).Single();
                int c14 = (from c in context.Cohort
                           where c.Number.Equals("C14")
                           select c.Id).Single();
                int c15 = (from c in context.Cohort
                           where c.Number.Equals("C15")
                           select c.Id).Single();
                int c16 = (from c in context.Cohort
                           where c.Number.Equals("C16")
                           select c.Id).Single();
                int c17 = (from c in context.Cohort
                           where c.Number.Equals("C17")
                           select c.Id).Single();
                int c18 = (from c in context.Cohort
                           where c.Number.Equals("C18")
                           select c.Id).Single();
                int c19 = (from c in context.Cohort
                           where c.Number.Equals("C19")
                           select c.Id).Single();
                int c20 = (from c in context.Cohort
                           where c.Number.Equals("C20")
                           select c.Id).Single();
                int c21 = (from c in context.Cohort
                           where c.Number.Equals("C21")
                           select c.Id).Single();
                int c22 = (from c in context.Cohort
                           where c.Number.Equals("C22")
                           select c.Id).Single();
                int c23 = (from c in context.Cohort
                           where c.Number.Equals("C23")
                           select c.Id).Single();
                int c24 = (from c in context.Cohort
                           where c.Number.Equals("C24")
                           select c.Id).Single();
                int c25 = (from c in context.Cohort
                           where c.Number.Equals("C25")
                           select c.Id).Single();
                int e1 = (from c in context.Cohort
                          where c.Number.Equals("E1")
                          select c.Id).Single();
                int e2 = (from c in context.Cohort
                          where c.Number.Equals("E2")
                          select c.Id).Single();
                int e3 = (from c in context.Cohort
                          where c.Number.Equals("E3")
                          select c.Id).Single();
                int e4 = (from c in context.Cohort
                          where c.Number.Equals("E4")
                          select c.Id).Single();
                int e5 = (from c in context.Cohort
                          where c.Number.Equals("E5")
                          select c.Id).Single();
                int e6 = (from c in context.Cohort
                          where c.Number.Equals("E6")
                          select c.Id).Single();

                int thtml = (from t in context.Tech
                             where t.Name.Equals("HTML")
                             select t.Id).Single();
                int tjava = (from t in context.Tech
                             where t.Name.Equals("JavaScript")
                             select t.Id).Single();
                int tcss = (from t in context.Tech
                            where t.Name.Equals("CSS")
                            select t.Id).Single();
                int tnode = (from t in context.Tech
                             where t.Name.Equals("Node.JS")
                             select t.Id).Single();
                int truby = (from t in context.Tech
                             where t.Name.Equals("Ruby on Rails")
                             select t.Id).Single();
                int tgit = (from t in context.Tech
                            where t.Name.Equals("Git")
                            select t.Id).Single();
                int tfire = (from t in context.Tech
                             where t.Name.Equals("Firebase")
                             select t.Id).Single();
                int tstudio = (from t in context.Tech
                               where t.Name.Equals("Visual Studio")
                               select t.Id).Single();
                int tsql = (from t in context.Tech
                            where t.Name.Equals("SQL Server")
                            select t.Id).Single();
                int tlite = (from t in context.Tech
                             where t.Name.Equals("SQLLite")
                             select t.Id).Single();
                int tcsharp = (from t in context.Tech
                               where t.Name.Equals("C#")
                               select t.Id).Single();
                int tnet = (from t in context.Tech
                            where t.Name.Equals(".NET")
                            select t.Id).Single();
                int tasp = (from t in context.Tech
                            where t.Name.Equals("ASP.NET")
                            select t.Id).Single();
                int tpython = (from t in context.Tech
                               where t.Name.Equals("Python")
                               select t.Id).Single();
                int tdjango = (from t in context.Tech
                               where t.Name.Equals("Django")
                               select t.Id).Single();
                int tvscode = (from t in context.Tech
                               where t.Name.Equals("Visual Studio Code")
                               select t.Id).Single();
                int tsass = (from t in context.Tech
                             where t.Name.Equals("SASS")
                             select t.Id).Single();
                int tangular = (from t in context.Tech
                                where t.Name.Equals("Angular.JS")
                                select t.Id).Single();

                //c1
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c1,
                    TechId = truby
                });
                //c2
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c2,
                    TechId = truby
                });
                //c3
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c3,
                    TechId = truby
                });
                //c4
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c4,
                    TechId = truby
                });
                //c5
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c5,
                    TechId = truby
                });
                //c6
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c6,
                    TechId = tnode
                });
                //c7
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c7,
                    TechId = tcsharp
                });
                //c7
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c7,
                    TechId = tnet
                });
                //c8
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c8,
                    TechId = truby
                });
                //c9
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c9,
                    TechId = tnode
                });
                //c10
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c10,
                    TechId = tcsharp
                });
                //c10
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c10,
                    TechId = tnet
                });
                //c11
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c11,
                    TechId = tnode
                });
                //c12
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c12,
                    TechId = tcsharp
                });
                //c12
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c12,
                    TechId = tnet
                });
                //c13
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c13,
                    TechId = tpython
                });
                //c13
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c13,
                    TechId = tdjango
                });
                //c14
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c14,
                    TechId = tnode
                });
                //c15
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c15,
                    TechId = tcsharp
                });
                //c15
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c15,
                    TechId = tnet
                });
                //c16
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c16,
                    TechId = tpython
                });
                //c17
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c17,
                    TechId = tnode
                });
                //c18
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c18,
                    TechId = tpython
                });
                //c18
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c18,
                    TechId = tdjango
                });
                //c19
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c19,
                    TechId = tcsharp
                });
                //c19
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c19,
                    TechId = tnet
                });
                //c20
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c20,
                    TechId = tnode
                });
                //c21
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c21,
                    TechId = truby
                });
                //c22
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c22,
                    TechId = tcsharp
                });
                //c22
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c22,
                    TechId = tnet
                });
                //c22
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c22,
                    TechId = tangular
                });
                //c23
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c23,
                    TechId = tnode
                });
                //c24
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c24,
                    TechId = thtml
                });
                //c24
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c24,
                    TechId = tcss
                });
                //c24
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c24,
                    TechId = tsass
                });
                //c25
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c25,
                    TechId = tpython
                });
                //c25
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = c25,
                    TechId = tdjango
                });

                //e1
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = e1,
                    TechId = tcsharp
                });

                //e1
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = e1,
                    TechId = tnet
                });

                //e2
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = e2,
                    TechId = tcsharp
                });

                //e2
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = e2,
                    TechId = tnet
                });

                //e3
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = e3,
                    TechId = tcsharp
                });

                //e3
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = e3,
                    TechId = tnet
                });

                //e4
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = e4,
                    TechId = tcsharp
                });

                //e4
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = e4,
                    TechId = tnet
                });

                //e5
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = e5,
                    TechId = tcsharp
                });

                //e5
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = e5,
                    TechId = tnet
                });

                //e6
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = e6,
                    TechId = tcsharp
                });

                //e6
                context.CohortTech.Add(new CohortTech
                {
                    CohortId = e6,
                    TechId = tnet
                });
                context.SaveChanges();
            }

            /************************/
            /* Seeding Meetup Table */
            /************************/
            if (!context.Meetup.Any())
            {
                int thtml = (from t in context.Tech
                             where t.Name.Equals("HTML")
                             select t.Id).Single();
                int tjava = (from t in context.Tech
                             where t.Name.Equals("JavaScript")
                             select t.Id).Single();
                int tcss = (from t in context.Tech
                            where t.Name.Equals("CSS")
                            select t.Id).Single();
                int tnode = (from t in context.Tech
                             where t.Name.Equals("Node.JS")
                             select t.Id).Single();
                int truby = (from t in context.Tech
                             where t.Name.Equals("Ruby on Rails")
                             select t.Id).Single();
                int tgit = (from t in context.Tech
                            where t.Name.Equals("Git")
                            select t.Id).Single();
                int tfire = (from t in context.Tech
                             where t.Name.Equals("Firebase")
                             select t.Id).Single();
                int tstudio = (from t in context.Tech
                               where t.Name.Equals("Visual Studio")
                               select t.Id).Single();
                int tsql = (from t in context.Tech
                            where t.Name.Equals("SQL Server")
                            select t.Id).Single();
                int tlite = (from t in context.Tech
                             where t.Name.Equals("SQLLite")
                             select t.Id).Single();
                int tcsharp = (from t in context.Tech
                               where t.Name.Equals("C#")
                               select t.Id).Single();
                int tnet = (from t in context.Tech
                            where t.Name.Equals(".NET")
                            select t.Id).Single();
                int tasp = (from t in context.Tech
                            where t.Name.Equals("ASP.NET")
                            select t.Id).Single();
                int tpython = (from t in context.Tech
                               where t.Name.Equals("Python")
                               select t.Id).Single();
                int tdjango = (from t in context.Tech
                               where t.Name.Equals("Django")
                               select t.Id).Single();
                int tvscode = (from t in context.Tech
                               where t.Name.Equals("Visual Studio Code")
                               select t.Id).Single();
                int tsass = (from t in context.Tech
                             where t.Name.Equals("SASS")
                             select t.Id).Single();
                int tangular = (from t in context.Tech
                             where t.Name.Equals("Angular.JS")
                             select t.Id).Single();
                int tgeneral = (from t in context.Tech
                                where t.Name.Equals("General/Non-Specific")
                                select t.Id).Single();
                int tunknown = (from t in context.Tech
                                where t.Name.Equals("Unknown")
                                select t.Id).Single();


                //Developer Launchpad
                context.Meetup.Add(new Meetup
                {
                    Name = "Developer Launchpad",
                    Description = "If you're looking to launch your developer career to the next level and are looking for a friendly group in the Nashville area to code with, join Developer Launchpad Nashville!",
                    TechId = tgeneral
                });
                //'Boro Dev Breakfast
                context.Meetup.Add(new Meetup
                {
                    Name = "'Boro Dev Breakfast",
                    Description = "Anyone is welcome to come eat breakfast with us. This is an open group. We will discuss .NET, CMS, PHP, & JS. BoroDev is a collection of top web and app development talent in and around Murfreesboro, TN. Our goal is to continually learn and grow as developers and ultimately establish Murfreesboro as a tech hub. We’re a supportive resource for aspiring, growing, and experienced developers alike.",
                    TechId = tgeneral
                });
                //NashJS
                context.Meetup.Add(new Meetup
                {
                    Name = "NashJS",
                    Description = "A group for people interested in software development using Javascript. ",
                    TechId = tjava
                });
                //All Things Angular
                context.Meetup.Add(new Meetup
                {
                    Name = "All Things Angular",
                    Description = "A community of Angular enthusiasts and professionals meeting near Franklin, TN.",
                    TechId = tangular
                });
                
                context.SaveChanges();
            }
        }
    }
}