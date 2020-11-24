using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevelopmentChecklist.Models;

namespace DevelopmentChecklist.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ChecklistContext context)
        {
            context.Database.EnsureCreated();
            //Look for Applications
            if (context.Applications.Any())
            {
                return; //DB has been seeded
            }

            var applications = new Application[]
            {
                new Application{AppName="A2D2", AppURL="dasbhoard.A2D2.com", AppDescription="A2D2 Application", AppStatus=AppStatus.WIP, DateCreated=DateTime.Parse("2005-09-01")},
                new Application{AppName="Attorney Metrics", AppURL ="dashboard.AttorneyMetrics.com", AppDescription="Dashboard for Attorney Metrics", AppStatus=AppStatus.Live, DateCreated=DateTime.Parse("2020-09-01") },
                new Application{AppName="Group Sites", AppURL="dashboard.GroupSites.com", AppDescription="Pages for different teams", AppStatus=AppStatus.Testing, DateCreated=DateTime.Parse("2019-04-05")},
                new Application{AppName="Business Activity", AppURL="dasbhoard.BusinessActivity.com", AppDescription="Site to log different activities", AppStatus=AppStatus.Live, DateCreated=DateTime.Parse("2020-10-12") },
                new Application{AppName="Mobile App", AppURL="mobile.application.com", AppDescription="iPhone App", AppStatus=AppStatus.InDevelopment, DateCreated=DateTime.Parse("2018-01-01")}
            };
            foreach (Application a in applications)
            {
                context.Applications.Add(a);
            }
            context.SaveChanges();


            var developers = new Developer[]
            {
                new Developer{DeveloperFirstName="Jacob", DeveloperLastName="Kepford"},
                new Developer{DeveloperFirstName="Bob", DeveloperLastName="Stoyan"},
                new Developer{DeveloperFirstName="Mya", DeveloperLastName="Patesh"},
                new Developer{DeveloperFirstName="Martin", DeveloperLastName="Drak"},
                new Developer{DeveloperFirstName="Farkus", DeveloperLastName="Limerick"},
                new Developer{DeveloperFirstName="Brian", DeveloperLastName="Patrick"},
                new Developer{DeveloperFirstName="Sara", DeveloperLastName="Limez"}
            };
            foreach (Developer d in developers)
            {
                context.Developers.Add(d);
            }
            context.SaveChanges();

            var notes = new Note[]
            {
                new Note{AppID=1, NoteText="Bringing down to In Development", DeveloperID=5, NoteDate=DateTime.Parse("2005-05-05")},
                new Note{AppID=2, NoteText="Live on Production", DeveloperID=3, NoteDate=DateTime.Parse("2020-09-01")},
                new Note{AppID=3, NoteText="Adding changes to controller", DeveloperID=1, NoteDate=DateTime.Parse("2020-04-05")},
                new Note{AppID=4, NoteText="Adding UI Enhancements", DeveloperID=2, NoteDate=DateTime.Parse("2020-10-20")},
                new Note{AppID=4, NoteText="Reverting UI Enhancements", DeveloperID=2, NoteDate=DateTime.Parse("2020-10-21")},
                new Note{AppID=5, NoteText="Fixing Floor Maps", DeveloperID=6, NoteDate=DateTime.Parse("2020-11-08")}
            };
            foreach (Note n in notes)
            {
                context.Notes.Add(n);
            }
            context.SaveChanges();
        }
    }
}
