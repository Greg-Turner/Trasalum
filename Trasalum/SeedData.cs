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
            /************************/
            /* Seeding Tech Table */
            /************************/
            if (!context.Tech.Any())
            {
                context.Tech.Add(new Tech
                {
                    Name = "HTML",
                });
                context.Tech.Add(new Tech
                {
                    Name = "JavaScript",
                });
                context.Tech.Add(new Tech
                {
                    Name = "CSS",
                });
                context.Tech.Add(new Tech
                {
                    Name = "C#",
                });
                context.Tech.Add(new Tech
                {
                    Name = "Ruby on Rails",
                });
                context.Tech.Add(new Tech
                {
                    Name = "Python",
                });
                context.Tech.Add(new Tech
                {
                    Name = "Git",
                });
                context.Tech.Add(new Tech
                {
                    Name = ".NET",
                });
                context.Tech.Add(new Tech
                {
                    Name = "GitHub",
                });
                context.Tech.Add(new Tech
                {
                    Name = "ASP.NET",
                });
                context.Tech.Add(new Tech
                {
                    Name = "SASS",
                });
                context.Tech.Add(new Tech
                {
                    Name = "Visual Studio",
                });
                context.Tech.Add(new Tech
                {
                    Name = "Visual Studio Code",
                });
                context.Tech.Add(new Tech
                {
                    Name = "SCRUM",
                });
                context.Tech.Add(new Tech
                {
                    Name = "Firebase",
                });
                context.Tech.Add(new Tech
                {
                    Name = "SQL Server",
                });
                context.Tech.Add(new Tech
                {
                    Name = "SQLLite",
                });
                context.Tech.Add(new Tech
                {
                    Name = "Node.JS",
                });
                context.Tech.Add(new Tech
                {
                    Name = "Django",
                });
                context.SaveChanges();
            }
            
            /*****************************/
            /* Seeding CohortStaff Table */
            /*****************************/
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
                    Staff = john
                });
                //c1
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c1,
                    Staff = eliza
                });
                //c2
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c2,
                    Staff = adam
                });
                //c2
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c2,
                    Staff = eliza
                });
                //c2
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c2,
                    Staff = john
                });
                //c3
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c3,
                    Staff = eliza
                });
                //c3
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c3,
                    Staff = chyld
                });
                //c4
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c4,
                    Staff = chyld
                });
                //c4
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c4,
                    Staff = eliza
                });
                //c5
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c5,
                    Staff = chyld
                });
                //c5
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c5,
                    Staff = eliza
                });
                //c6
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c6,
                    Staff = chyld
                });
                //c7
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c7,
                    Staff = eliza
                });
                //c7
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c7,
                    Staff = scott
                });
                //c7
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c7,
                    Staff = jurnell
                });
                //c8
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c8,
                    Staff = eliza
                });
                //c8
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c8,
                    Staff = scott
                });
                //c8
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c8,
                    Staff = jurnell
                });
                //c9
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c9,
                    Staff = scott
                });
                //c10
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c10,
                    Staff = eliza
                });
                //c10
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c10,
                    Staff = steve
                });
                //c10
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c10,
                    Staff = jurnell
                });
                //c11
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c11,
                    Staff = steve
                });
                //c11
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c11,
                    Staff = scott
                });
                //c12
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c12,
                    Staff = caitlyn
                });
                //c12
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c12,
                    Staff = denise
                });
                //c12
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c12,
                    Staff = steve
                });
                //c12
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c12,
                    Staff = joe
                });
                //c13
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c13,
                    Staff = joe
                });
                //c13
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c13,
                    Staff = scott
                });
                //c13
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c13,
                    Staff = steve
                });
                //c14
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c14,
                    Staff = joe
                });
                //c14
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c14,
                    Staff = scott
                });
                //c14
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c14,
                    Staff = callan
                });
                //c15
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c15,
                    Staff = caitlyn
                });
                //c15
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c15,
                    Staff = joe
                });
                //c15
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c15,
                    Staff = scott
                });
                //c15
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c15,
                    Staff = denise
                });
                //c15
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c15,
                    Staff = greg
                });
                //c16
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c16,
                    Staff = brenda
                });
                //c16
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c16,
                    Staff = joe
                });
                //c16
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c16,
                    Staff = steve
                });
                //c17
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c17,
                    Staff = joe
                });
                //c17
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c17,
                    Staff = scott
                });
                //c18
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c18,
                    Staff = brenda
                });
                //c18
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c18,
                    Staff = steve
                });
                //c19
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c19,
                    Staff = brenda
                });
                //c19
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c19,
                    Staff = steve
                });
                //c20
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c20,
                    Staff = joe
                });
                //c21
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c21,
                    Staff = brenda
                });
                //c21
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c21,
                    Staff = steve
                });
                //c22
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c22,
                    Staff = steve
                });
                //c23
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c23,
                    Staff = joe
                });
                //c24
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c24,
                    Staff = brenda
                });
                //c25
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = c25,
                    Staff = steve
                });

                //e1
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e1,
                    Staff = steve
                });
                //e1
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e1,
                    Staff = jurnell
                });
                //e2
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e2,
                    Staff = steve
                });
                //e2
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e2,
                    Staff = jurnell
                });
                //e2
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e2,
                    Staff = joe
                });
                //e3
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e3,
                    Staff = zoe
                });
                //e3
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e3,
                    Staff = jurnell
                });
                //e3
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e3,
                    Staff = joe
                });
                //e4
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e4,
                    Staff = zoe
                });
                //e4
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e4,
                    Staff = jurnell
                });
                //e4
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e4,
                    Staff = nathan
                });
                //e5
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e5,
                    Staff = zoe
                });
                //e5
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e5,
                    Staff = jurnell
                });
                //e6
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e6,
                    Staff = zoe
                });
                //e6
                context.CohortStaff.Add(new CohortStaff
                {
                    CohortId = e6,
                    Staff = jurnell
                });

                context.SaveChanges();
            }

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

                context.SaveChanges();


            }
        }
}