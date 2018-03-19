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

            /****************************/
            /* Seeding Department Table */
            /****************************/
            if (!context.Department.Any())
            {
                context.Department.Add(new Department
                {
                    Name = "Educator",
                });

                context.Department.Add(new Department
                {
                    Name = "Operations",
                });
                context.SaveChanges();
            }

            /************************/
            /* Seeding Cohort Table */
            /************************/
            if (!context.Cohort.Any())
            {
                context.Cohort.Add(new Cohort
                {
                    Id = "C1",
                    StartDate = DateTime.ParseExact("01/06/2012 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("30/11/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C2",
                    StartDate = DateTime.ParseExact("01/01/2013 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("30/06/2013 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C3",
                    StartDate = DateTime.ParseExact("01/09/2013 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("30/03/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C4",
                    StartDate = DateTime.ParseExact("04/01/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("22/06/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C5",
                    StartDate = DateTime.ParseExact("05/04/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("24/09/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C6",
                    StartDate = DateTime.ParseExact("05/07/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("13/01/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C7",
                    StartDate = DateTime.ParseExact("03/09/2014 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("24/03/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C8",
                    StartDate = DateTime.ParseExact("04/01/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/06/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "E1",
                    StartDate = DateTime.ParseExact("06/02/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("12/01/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C9",
                    StartDate = DateTime.ParseExact("06/04/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("25/09/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C10",
                    StartDate = DateTime.ParseExact("06/07/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("12/01/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "E2",
                    StartDate = DateTime.ParseExact("06/07/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/06/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C11",
                    StartDate = DateTime.ParseExact("05/10/2015 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("25/03/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "E3",
                    StartDate = DateTime.ParseExact("03/01/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("10/01/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C12",
                    StartDate = DateTime.ParseExact("02/01/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/06/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C13",
                    StartDate = DateTime.ParseExact("04/04/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/09/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C14",
                    StartDate = DateTime.ParseExact("14/05/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("04/11/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C15",
                    StartDate = DateTime.ParseExact("05/07/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("10/01/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "E4",
                    StartDate = DateTime.ParseExact("05/07/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/06/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C16",
                    StartDate = DateTime.ParseExact("03/10/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("24/03/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C17",
                    StartDate = DateTime.ParseExact("14/11/2016 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("19/05/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C18",
                    StartDate = DateTime.ParseExact("03/01/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/06/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "E5",
                    StartDate = DateTime.ParseExact("03/01/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("09/01/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C19",
                    StartDate = DateTime.ParseExact("03/04/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("22/09/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C20",
                    StartDate = DateTime.ParseExact("22/05/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("10/11/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C21",
                    StartDate = DateTime.ParseExact("05/07/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("09/01/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "E6",
                    StartDate = DateTime.ParseExact("05/07/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("22/06/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C22",
                    StartDate = DateTime.ParseExact("02/10/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("23/03/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C23",
                    StartDate = DateTime.ParseExact("13/11/2017 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("18/05/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C24",
                    StartDate = DateTime.ParseExact("02/01/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("22/06/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.Cohort.Add(new Cohort
                {
                    Id = "C25",
                    StartDate = DateTime.ParseExact("02/04/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null),
                    DemoDate = DateTime.ParseExact("21/09/2018 00:00:00", "dd/MM/yyyy HH:mm:ss", null)
                });

                context.SaveChanges();
            }

            /*************************/
            /* Seeding Alum Table */
            /*************************/
            if (!context.Alum.Any())
            {
                string c1 = (from c in context.Cohort
                          where c.Id.Equals("C1")
                          select c.Id).Single();
                string c2 = (from c in context.Cohort
                          where c.Id.Equals("C2")
                          select c.Id).Single();
                string c3 = (from c in context.Cohort
                          where c.Id.Equals("C3")
                          select c.Id).Single();
                string c4 = (from c in context.Cohort
                          where c.Id.Equals("C4")
                          select c.Id).Single();
                string c22 = (from c in context.Cohort
                          where c.Id.Equals("C22")
                          select c.Id).Single();

                context.Alum.Add(new Alum
                {
                    FirstName = "John",
                    LastName = "Smith",
                    CohortId = c1,
                    Address = "1 Main St.",
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37201",
                    Phone = "615-222-3344",
                    Email = "jsmith@email.com",
                    GitHub = "john-smith",
                    LinkedIn = "john-smith",
                    Slack = "john-smith"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    CohortId = c1,
                    Address = "2 Broad St.",
                    City = "Murfreesboro",
                    State = "TN",
                    ZipCode = "37129",
                    Phone = "615-333-2255",
                    Email = "jdoe@email.com",
                    GitHub = "jane-doe",
                    LinkedIn = "jane-doe",
                    Slack = "jane-doe"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Scott",
                    LastName = "Gordon",
                    CohortId = c2,
                    Address = "3 West St.",
                    City = "Clarksville",
                    State = "TN",
                    ZipCode = "37024",
                    Phone = "615-777-5533",
                    Email = "sgordon@email.com",
                    GitHub = "scott-gordon",
                    LinkedIn = "scott-gordon",
                    Slack = "scott-gordon"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Renee",
                    LastName = "Lynn",
                    CohortId = c2,
                    Address = "12 East Ave.",
                    City = "Hendersonville",
                    State = "TN",
                    ZipCode = "37066",
                    Phone = "615-579-2134",
                    Email = "rlynn@email.com",
                    GitHub = "renee-lynn",
                    LinkedIn = "renee-lynn",
                    Slack = "renee-lynn"
                });
                context.Alum.Add(new Alum
                {
                    FirstName = "Tom",
                    LastName = "Williams",
                    CohortId = c2,
                    Address = "456 King Blvd.",
                    City = "Rockvale",
                    State = "TN",
                    ZipCode = "37031",
                    Phone = "615-923-8765",
                    Email = "twilliams@email.com",
                    GitHub = "tom-williams",
                    LinkedIn = "tom-williams",
                    Slack = "tom-williams"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Robert",
                    LastName = "Roberts",
                    CohortId = c3,
                    Address = "11 Roberta Lane.",               
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37214",
                    Phone = "615-324-1234",
                    Email = "rroberts@email.com",
                    GitHub = "robert-roberts",
                    LinkedIn = "robert-roberts",
                    Slack = "robert-roberts"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Kim",
                    LastName = "Fields",
                    CohortId = c3,
                    Address = "98 Pasture St.",              
                    City = "Smyrna",
                    State = "TN",
                    ZipCode = "37126",
                    Phone = "615-345-7654",
                    Email = "kfields@email.com",
                    GitHub = "kim-fields",
                    LinkedIn = "kim-fields",
                    Slack = "kim-fields"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Larry",
                    LastName = "Thomas",
                    CohortId = c3,
                    Address = "65 1st St.",     
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37201",
                    Phone = "615-865-9078",
                    Email = "lthomas@email.com",
                    GitHub = "larry-thomas",
                    LinkedIn = "larry-thomas",
                    Slack = "larry-thomas"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Jeff",
                    LastName = "Stanton",
                    CohortId = c3,
                    Address = "101 Champion St.",
                    City = "White Bluff",
                    State = "TN",
                    ZipCode = "37113",
                    Phone = "615-723-1738",
                    Email = "jstanton@email.com",
                    GitHub = "jeff-stanton",
                    LinkedIn = "jeff-stanton",
                    Slack = "jeff-stanton"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Damon",
                    LastName = "Bradshaw",
                    CohortId = c3,
                    Address = "101 Speedy Way",
                    City = "Murfreesboro",
                    State = "TN",
                    ZipCode = "37127",
                    Phone = "615-327-8371",
                    Email = "dbradshaw@email.com",
                    GitHub = "damon-bradshaw",
                    LinkedIn = "damon-bradshaw",
                    Slack = "damon-bradshaw"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Sue",
                    LastName = "Ward",
                    CohortId = c3,
                    Address = "7 Bridal Dr.",
                    City = "Lascassas",
                    State = "TN",
                    ZipCode = "37134",
                    Phone = "615-221-9335",
                    Email = "sward@email.com",
                    GitHub = "sue-ward",
                    LinkedIn = "sue-ward",
                    Slack = "sue-ward"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Ricky",
                    LastName = "Carmichael",
                    CohortId = c3,
                    Address = "4 Goat St.",
                    City = "Murfreesboro",
                    State = "TN",
                    ZipCode = "37130",
                    Phone = "615-546-9976",
                    Email = "rcarmichael@email.com",
                    GitHub = "ricky-carmichael",
                    LinkedIn = "ricky-carmichael",
                    Slack = "ricky-carmichael"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Justin",
                    LastName = "Barcia",
                    CohortId = c3,
                    Address = "23 Bam Bam St.",
                    City = "Hermitage",
                    State = "TN",
                    ZipCode = "37076",
                    Phone = "615-812-1298",
                    Email = "jbarcia@email.com",
                    GitHub = "justin-barcia",
                    LinkedIn = "justin-barcia",
                    Slack = "justin-barcia"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Mike",
                    LastName = "Alessi",
                    CohortId = c3,
                    Address = "2 Crash St.",
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37221",
                    Phone = "615-383-9747",
                    Email = "malessi@email.com",
                    GitHub = "mike-alessi",
                    LinkedIn = "mike-alessi",
                    Slack = "mike-alessi"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Andrew",
                    LastName = "Short",
                    CohortId = c3,
                    Address = "28 Rider Dr.",
                    City = "Mt Juliet",
                    State = "TN",
                    ZipCode = "37122",
                    Phone = "615-325-0026",
                    Email = "ashort@email.com",
                    GitHub = "andrew-short",
                    LinkedIn = "andrew-short",
                    Slack = "andrew-short"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Samantha",
                    LastName = "Burns",
                    CohortId = c4,
                    Address = "344 View St.",
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37205",
                    Phone = "615-865-9846",
                    Email = "sburns@email.com",
                    GitHub = "samantha-burns",
                    LinkedIn = "samantha-burns",
                    Slack = "samanatha-burns"
                });

                context.Alum.Add(new Alum
                {
                    FirstName = "Guy",
                    LastName = "Cooper",
                    CohortId = c4,
                    Address = "5 Airtime Lane",
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37215",
                    Phone = "615-332-4599",
                    Email = "gcooper@email.com",
                    GitHub = "guy-cooper",
                    LinkedIn = "guy-cooper",
                    Slack = "guy-cooper"
                });
                context.Alum.Add(new Alum
                {
                    FirstName = "Greg",
                    LastName = "Lawrence",
                    CohortId = c22,
                    Address = "1 Rockstar Blvd",
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37205",
                    Phone = "615-352-9737",
                    Email = "gregaudio@gmail.com",
                    GitHub = "https://github.com/chewieez",
                    LinkedIn = "https://www.linkedIn.com/in/gregmlawrence",
                    Slack = "Greg Lawrence"
                });
                context.Alum.Add(new Alum
                {
                    FirstName = "Jason",
                    LastName = "Figueroa",
                    CohortId = c22,
                    Address = "1 Microsoft St.",
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37214",
                    Phone = "615-383-4406",
                    Email = "jason.figueroa2@gmail.com",
                    GitHub = "https://github.com/jasonfigueroa",
                    LinkedIn = "https://www.linkedin.com/in/jason-figueroa-b59a3798/",
                    Slack = "Jason Figueroa"
                });
                context.Alum.Add(new Alum
                {
                    FirstName = "Kimberly",
                    LastName = "Bird",
                    CohortId = c22,
                    Address = "1 Avian Ave.",
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37221",
                    Phone = "615-646-1973",
                    Email = "kimberly.j.bird@gmail.com",
                    GitHub = "https://github.com/kimberly-bird",
                    LinkedIn = "https://www.linkedin.com/in/kimberly-j-bird/",
                    Slack = "Kimmy Bird"
                });
                context.Alum.Add(new Alum
                {
                    FirstName = "Erin",
                    LastName = "Agobert",
                    CohortId = c22,
                    Address = "1 Coffee Into Code Circle",
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37221",
                    Phone = "615-588-9638",
                    Email = "eagobert1@gmail.com",
                    GitHub = "https://github.com/eagobert",
                    LinkedIn = "https://www.linkedin.com/in/eagobert/",
                    Slack = "Erin Agobert"
                });
                context.Alum.Add(new Alum
                {
                    FirstName = "Ray",
                    LastName = "Medrano",
                    CohortId = c22,
                    Address = "1 Greetings Way",
                    City = "Mt Juliet",
                    State = "TN",
                    ZipCode = "37122",
                    Phone = "615-221-1791",
                    Email = "rmbw74@gmail.com",
                    GitHub = "www.github.com/rmbw74",
                    LinkedIn = "www.linkedin.com/in/rmbw74",
                    Slack = "Ray Medrano"
                });
                context.Alum.Add(new Alum
                {
                    FirstName = "Kevin",
                    LastName = "Haggerty",
                    CohortId = c22,
                    Address = "1 Next Adventure Circle",
                    City = "Franklin",
                    State = "TN",
                    ZipCode = "37064",
                    Phone = "615-642-5582",
                    Email = "kghaggerty@gmail.com",
                    GitHub = "www.github.com/kghaggerty",
                    LinkedIn = "https://www.linkedin.com/in/kevin-haggerty-ab310b56/",
                    Slack = "Kevin Haggerty"
                });
                context.Alum.Add(new Alum
                {
                    FirstName = "Lissa",
                    LastName = "Goforth",
                    CohortId = c22,
                    Address = "1 Sudo Commander Drive",
                    City = "Madison",
                    State = "TN",
                    ZipCode = "37027",
                    Phone = "615-331-7193",
                    Email = "lissagoforthsoftwaredev@gmail.com",
                    GitHub = "https://github.com/lissagoforth",
                    LinkedIn = "linkedin.com/in/lissagoforth-softwaredeveloper/",
                    Slack = "Lissa Goforth"
                });
                context.Alum.Add(new Alum
                {
                    FirstName = "Chris",
                    LastName = "Miller",
                    CohortId = c22,
                    Address = "1 Sleeping Bed Blvd.",
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37208",
                    Phone = "615-822-3579",
                    Email = "camiller.yr@gmail.com",
                    GitHub = "www.github.com/camillery",
                    LinkedIn = "www.linkedin.com/in/camilleryr",
                    Slack = "Chris Miller"
                });
                context.Alum.Add(new Alum
                {
                    FirstName = "John",
                    LastName = "Delaney",
                    CohortId = c22,
                    Address = "1 McLovin Computers Court",
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37208",
                    Phone = "615-244-8811",
                    Email = "john.s.dulaney1@gmail.com",
                    GitHub = "https://github.com/john-dulaney",
                    LinkedIn = "https://www.linkedin.com/in/john-dulaney-032143130/",
                    Slack = "John Delaney"
                });
                context.Alum.Add(new Alum
                {
                    FirstName = "Kristen",
                    LastName = "Norris",
                    CohortId = c22,
                    Address = "1 Non-Profit Tech St.",
                    City = "Nashville",
                    State = "TN",
                    ZipCode = "37211",
                    Phone = "615-838-7594",
                    Email = "krnorris65@gmail.com",
                    GitHub = "www.github.com/krnorris65",
                    LinkedIn = "www.linkedin.com/in/krnorris65",
                    Slack = "Kristen Norris"
                });
                context.Alum.Add(new Alum
                {
                    FirstName = "Chase",
                    LastName = "Steely",
                    CohortId = c22,
                    Address = "1 Veteren Learner Dr.",
                    City = "McMinnville",
                    State = "TN",
                    ZipCode = "37227",
                    Phone = "615-689-2624",
                    Email = "chasesteely@gmail.com",
                    GitHub = "https://github.com/ChaseSteely",
                    LinkedIn = "https://www.linkedin.com/in/chasesteely/",
                    Slack = "Chase Steely"
                });
                context.SaveChanges();
            }

            /***********************/
            /* Seeding Staff Table */
            /***********************/
            if (!context.Staff.Any())
            {
                int educator = (from d in context.Department
                                where d.Name.Equals("Educator")
                                select d.Id).Single();
                int operations = (from d in context.Department
                                 where d.Name.Equals("Operations")
                                 select d.Id).Single();

                context.Staff.Add(new Staff
                {
                    Name = "Steve Brownlee",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Greg Korte",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Hannah Hall",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Eliza Brock",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "John Wark",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Adam Scott",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Chyld Medford",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Scott Humphries",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Jurnell Cockhren",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Joe Shepherd",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Zoe Ames",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Denise Tinsley",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Caitlyn Stein",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Callan Morrison",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Nathan Gonzalez",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Brenda Long",
                    DepartmentId = educator,
                });
                context.Staff.Add(new Staff
                {
                    Name = "Greg Turner",
                    DepartmentId = operations,
                });
                context.SaveChanges();
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
                    Name = "(General/Non-Specific)"
                });
                context.Tech.Add(new Tech
                {
                    Name = "(Unknown)"
                });
                context.Tech.Add(new Tech
                {
                    Name = "(N/A)"
                });

                context.SaveChanges();
            }

            /*****************************/
            /* Seeding CohortStaff Table */
            /*****************************/
            
            if (!context.CohortStaff.Any())
            {
                int john = (from s in context.Staff
                          where s.Name.Equals("John Wark")
                          select s.Id).Single();
                int eliza = (from s in context.Staff
                            where s.Name.Equals("Eliza Brock")
                            select s.Id).Single();
                int adam = (from s in context.Staff
                            where s.Name.Equals("Adam Scott")
                            select s.Id).Single();
                int chyld = (from s in context.Staff
                            where s.Name.Equals("Chyld Medford")
                            select s.Id).Single();
                int scott = (from s in context.Staff
                            where s.Name.Equals("Scott Humphries")
                            select s.Id).Single();
                int jurnell = (from s in context.Staff
                            where s.Name.Equals("Jurnell Cockhren")
                            select s.Id).Single();
                int steve = (from s in context.Staff
                            where s.Name.Equals("Steve Brownlee")
                            select s.Id).Single();
                int joe = (from s in context.Staff
                            where s.Name.Equals("Joe Shepherd")
                            select s.Id).Single();
                int zoe = (from s in context.Staff
                            where s.Name.Equals("Zoe Ames")
                            select s.Id).Single();
                int denise = (from s in context.Staff
                            where s.Name.Equals("Denise Tinsley")
                            select s.Id).Single();
                int caitlyn = (from s in context.Staff
                            where s.Name.Equals("Caitlyn Stein")
                            select s.Id).Single();
                int greg = (from s in context.Staff
                            where s.Name.Equals("Greg Korte")
                            select s.Id).Single();
                int nathan = (from s in context.Staff
                            where s.Name.Equals("Nathan Gonzalez")
                            select s.Id).Single();
                int brenda = (from s in context.Staff
                            where s.Name.Equals("Brenda Long")
                            select s.Id).Single();
                int callan = (from s in context.Staff
                            where s.Name.Equals("Callan Morrison")
                            select s.Id).Single();
                
                string c1 = (from c in context.Cohort
                          where c.Id.Equals("C1")
                          select c.Id).Single();
                string c2 = (from c in context.Cohort
                          where c.Id.Equals("C2")
                          select c.Id).Single();
                string c3 = (from c in context.Cohort
                          where c.Id.Equals("C3")
                          select c.Id).Single();
                string c4 = (from c in context.Cohort
                          where c.Id.Equals("C4")
                          select c.Id).Single();
                string c5 = (from c in context.Cohort
                          where c.Id.Equals("C5")
                          select c.Id).Single();
                string c6 = (from c in context.Cohort
                          where c.Id.Equals("C6")
                          select c.Id).Single();
                string c7 = (from c in context.Cohort
                          where c.Id.Equals("C7")
                          select c.Id).Single();
                string c8 = (from c in context.Cohort
                          where c.Id.Equals("C8")
                          select c.Id).Single();
                string c9 = (from c in context.Cohort
                          where c.Id.Equals("C9")
                          select c.Id).Single();
                string c10 = (from c in context.Cohort
                           where c.Id.Equals("C10")
                           select c.Id).Single();
                string c11 = (from c in context.Cohort
                           where c.Id.Equals("C11")
                           select c.Id).Single();
                string c12 = (from c in context.Cohort
                           where c.Id.Equals("C12")
                           select c.Id).Single();
                string c13 = (from c in context.Cohort
                           where c.Id.Equals("C13")
                           select c.Id).Single();
                string c14 = (from c in context.Cohort
                           where c.Id.Equals("C14")
                           select c.Id).Single();
                string c15 = (from c in context.Cohort
                           where c.Id.Equals("C15")
                           select c.Id).Single();
                string c16 = (from c in context.Cohort
                           where c.Id.Equals("C16")
                           select c.Id).Single();
                string c17 = (from c in context.Cohort
                           where c.Id.Equals("C17")
                           select c.Id).Single();
                string c18 = (from c in context.Cohort
                           where c.Id.Equals("C18")
                           select c.Id).Single();
                string c19 = (from c in context.Cohort
                           where c.Id.Equals("C19")
                           select c.Id).Single();
                string c20 = (from c in context.Cohort
                           where c.Id.Equals("C20")
                           select c.Id).Single();
                string c21 = (from c in context.Cohort
                           where c.Id.Equals("C21")
                           select c.Id).Single();
                string c22 = (from c in context.Cohort
                           where c.Id.Equals("C22")
                           select c.Id).Single();
                string c23 = (from c in context.Cohort
                           where c.Id.Equals("C23")
                           select c.Id).Single();
                string c24 = (from c in context.Cohort
                           where c.Id.Equals("C24")
                           select c.Id).Single();
                string c25 = (from c in context.Cohort
                           where c.Id.Equals("C25")
                           select c.Id).Single();
                string e1 = (from c in context.Cohort
                          where c.Id.Equals("E1")
                          select c.Id).Single();
                string e2 = (from c in context.Cohort
                          where c.Id.Equals("E2")
                          select c.Id).Single();
                string e3 = (from c in context.Cohort
                          where c.Id.Equals("E3")
                          select c.Id).Single();
                string e4 = (from c in context.Cohort
                          where c.Id.Equals("E4")
                          select c.Id).Single();
                string e5 = (from c in context.Cohort
                          where c.Id.Equals("E5")
                          select c.Id).Single();
                string e6 = (from c in context.Cohort
                          where c.Id.Equals("E6")
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
            
            /*****************************/
            /* Seeding CohortTech Table */
            /*****************************/
            if (!context.CohortTech.Any())
            {
                string c1 = (from c in context.Cohort
                          where c.Id.Equals("C1")
                          select c.Id).Single();
                string c2 = (from c in context.Cohort
                          where c.Id.Equals("C2")
                          select c.Id).Single();
                string c3 = (from c in context.Cohort
                          where c.Id.Equals("C3")
                          select c.Id).Single();
                string c4 = (from c in context.Cohort
                          where c.Id.Equals("C4")
                          select c.Id).Single();
                string c5 = (from c in context.Cohort
                          where c.Id.Equals("C5")
                          select c.Id).Single();
                string c6 = (from c in context.Cohort
                          where c.Id.Equals("C6")
                          select c.Id).Single();
                string c7 = (from c in context.Cohort
                          where c.Id.Equals("C7")
                          select c.Id).Single();
                string c8 = (from c in context.Cohort
                          where c.Id.Equals("C8")
                          select c.Id).Single();
                string c9 = (from c in context.Cohort
                          where c.Id.Equals("C9")
                          select c.Id).Single();
                string c10 = (from c in context.Cohort
                           where c.Id.Equals("C10")
                           select c.Id).Single();
                string c11 = (from c in context.Cohort
                           where c.Id.Equals("C11")
                           select c.Id).Single();
                string c12 = (from c in context.Cohort
                           where c.Id.Equals("C12")
                           select c.Id).Single();
                string c13 = (from c in context.Cohort
                           where c.Id.Equals("C13")
                           select c.Id).Single();
                string c14 = (from c in context.Cohort
                           where c.Id.Equals("C14")
                           select c.Id).Single();
                string c15 = (from c in context.Cohort
                           where c.Id.Equals("C15")
                           select c.Id).Single();
                string c16 = (from c in context.Cohort
                           where c.Id.Equals("C16")
                           select c.Id).Single();
                string c17 = (from c in context.Cohort
                           where c.Id.Equals("C17")
                           select c.Id).Single();
                string c18 = (from c in context.Cohort
                           where c.Id.Equals("C18")
                           select c.Id).Single();
                string c19 = (from c in context.Cohort
                           where c.Id.Equals("C19")
                           select c.Id).Single();
                string c20 = (from c in context.Cohort
                           where c.Id.Equals("C20")
                           select c.Id).Single();
                string c21 = (from c in context.Cohort
                           where c.Id.Equals("C21")
                           select c.Id).Single();
                string c22 = (from c in context.Cohort
                           where c.Id.Equals("C22")
                           select c.Id).Single();
                string c23 = (from c in context.Cohort
                           where c.Id.Equals("C23")
                           select c.Id).Single();
                string c24 = (from c in context.Cohort
                           where c.Id.Equals("C24")
                           select c.Id).Single();
                string c25 = (from c in context.Cohort
                           where c.Id.Equals("C25")
                           select c.Id).Single();
                string e1 = (from c in context.Cohort
                          where c.Id.Equals("E1")
                          select c.Id).Single();
                string e2 = (from c in context.Cohort
                          where c.Id.Equals("E2")
                          select c.Id).Single();
                string e3 = (from c in context.Cohort
                          where c.Id.Equals("E3")
                          select c.Id).Single();
                string e4 = (from c in context.Cohort
                          where c.Id.Equals("E4")
                          select c.Id).Single();
                string e5 = (from c in context.Cohort
                          where c.Id.Equals("E5")
                          select c.Id).Single();
                string e6 = (from c in context.Cohort
                          where c.Id.Equals("E6")
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

            /*****************************/
            /* Seeding AlumTech Table */
            /*****************************/
            if (!context.AlumTech.Any())
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
                                where t.Name.Equals("(General/Non-Specific)")
                                select t.Id).Single();
                int tunknown = (from t in context.Tech
                                where t.Name.Equals("(Unknown)")
                                select t.Id).Single();

                int jsmith = (from a in context.Alum
                              where a.Email.Equals("jsmith@email.com")
                              select a.Id).Single();
                int jdoe = (from a in context.Alum
                            where a.Email.Equals("jdoe@email.com")
                            select a.Id).Single();
                int sgordon = (from a in context.Alum
                               where a.Email.Equals("sgordon@email.com")
                               select a.Id).Single();
                int rlynn = (from a in context.Alum
                             where a.Email.Equals("rlynn@email.com")
                             select a.Id).Single();
                int twilliams = (from a in context.Alum
                                 where a.Email.Equals("twilliams@email.com")
                                 select a.Id).Single();
                int rroberts = (from a in context.Alum
                                where a.Email.Equals("rroberts@email.com")
                                select a.Id).Single();
                int kfields = (from a in context.Alum
                               where a.Email.Equals("kfields@email.com")
                               select a.Id).Single();
                int lthomas = (from a in context.Alum
                               where a.Email.Equals("lthomas@email.com")
                               select a.Id).Single();
                int jstanton = (from a in context.Alum
                                where a.Email.Equals("jstanton@email.com")
                                select a.Id).Single();
                int dbradshaw = (from a in context.Alum
                                 where a.Email.Equals("dbradshaw@email.com")
                                 select a.Id).Single();
                int sward = (from a in context.Alum
                             where a.Email.Equals("sward@email.com")
                             select a.Id).Single();
                int rcarmichael = (from a in context.Alum
                                   where a.Email.Equals("rcarmichael@email.com")
                                   select a.Id).Single();
                int jbarcia = (from a in context.Alum
                               where a.Email.Equals("jbarcia@email.com")
                               select a.Id).Single();
                int malessi = (from a in context.Alum
                               where a.Email.Equals("malessi@email.com")
                               select a.Id).Single();
                int ashort = (from a in context.Alum
                              where a.Email.Equals("ashort@email.com")
                              select a.Id).Single();
                int sburns = (from a in context.Alum
                              where a.Email.Equals("sburns@email.com")
                              select a.Id).Single();
                int gcooper = (from a in context.Alum
                               where a.Email.Equals("gcooper@email.com")
                               select a.Id).Single();

                context.AlumTech.Add(new AlumTech
                {
                    AlumId = jsmith,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = jdoe,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = sgordon,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = rlynn,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = twilliams,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = rroberts,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = kfields,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = lthomas,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = jstanton,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = dbradshaw,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = sward,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = rcarmichael,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = jbarcia,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = malessi,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = ashort,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = sburns,
                    TechId = truby
                });
                context.AlumTech.Add(new AlumTech
                {
                    AlumId = gcooper,
                    TechId = truby
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
                                where t.Name.Equals("(General/Non-Specific)")
                                select t.Id).Single();
                int tunknown = (from t in context.Tech
                                where t.Name.Equals("(Unknown)")
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
            /****************************/
            /* Seeding ContactType Table */
            /****************************/
            if (!context.ContactType.Any())
            {
                context.ContactType.Add(new ContactType
                {
                    Name = "Phone",
                });
                context.ContactType.Add(new ContactType
                {
                    Name = "Email",
                });
                context.ContactType.Add(new ContactType
                {
                    Name = "Slack Message",
                });
                context.ContactType.Add(new ContactType
                {
                    Name = "LinkedIn Message",
                });
                context.ContactType.Add(new ContactType
                {
                    Name = "Letter",
                });
                context.ContactType.Add(new ContactType
                {
                    Name = "In-person conversation",
                });

                context.SaveChanges();
            }

            /****************************/
            /* Seeding Note Table */
            /****************************/
            if (!context.Note.Any())
            {
                context.Note.Add(new Note
                {
                    Detail = "NO CONTACTS LOGGED",
                });
                context.Note.Add(new Note
                {
                    Detail = "Phone number is no longer valid. Will update the alum profile and try another method to make contact.",
                });
                context.SaveChanges();
            }
            /*************************/
            /* Seeding Contact Table */
            /*************************/
            if (!context.Contact.Any())
            {

                int jsmith = (from a in context.Alum
                              where a.Email.Equals("jsmith@email.com")
                              select a.Id).Single();

                int steve = (from s in context.Staff
                             where s.Name.Equals("Steve Brownlee")
                             select s.Id).Single();

                int phone = (from ct in context.ContactType
                             where ct.Name.Equals("Phone")
                             select ct.Id).Single();

                int note1 = (from n in context.Note
                             where n.Detail.Equals("Phone number is no longer valid. Will update the alum profile and try another method to make contact.")
                             select n.Id).Single();

                context.Contact.Add(new Contact
                {
                    Success = false,
                    Date = DateTime.ParseExact("14/03/2018 10:04:00", "dd/MM/yyyy HH:mm:ss", null),
                    AlumId = jsmith,
                    StaffId = steve,
                    ContactTypeId = phone,
                    NoteId = note1
                });
                context.SaveChanges();
            }

        }
    }
}