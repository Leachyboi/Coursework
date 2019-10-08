using CCFTracker.Data;
using CCFTracker.DataModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCFTracker.SeedData
{
    public class SeedDataQualifications
    {
        public static void Initialise(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                //Search for current qualifications
                if (context.Qualification.Any())
                {
                    return; //DataBase has already been seeded
                }

                context.Qualification.AddRange(
                    new Qualification
                    {
                        QualName = "APC B- Drill",
                        ParOrChi = "Child",
                        Parent = "APC B"
                    },
                    new Qualification
                    {
                        QualName = "APC B- Shoot",
                        ParOrChi = "Child",
                        Parent = "APC B"
                    },
                    new Qualification
                    {
                        QualName = "APC B- Map and C",
                        ParOrChi = "Child",
                        Parent = "APC B"
                    },
                    new Qualification
                    {
                        QualName = "APC B- FC",
                        ParOrChi = "Child",
                        Parent = "APC B"
                    },
                    new Qualification
                    {
                        QualName = "APC B- 1st aid",
                        ParOrChi = "Child",
                        Parent = "APC B"
                    },
                    new Qualification
                    {
                        QualName = "APC B",
                        ParOrChi = "Parent",
                        NumChi = 5

                    },
                    new Qualification
                    {
                        QualName = "APC A- Drill",
                        ParOrChi = "Child",
                        Parent = "APC A"
                    },
                    new Qualification
                    {
                        QualName = "APC A- Shoot",
                        ParOrChi = "Child",
                        Parent = "APC A"
                    },
                    new Qualification
                    {
                        QualName = "APC A- Map and C",
                        ParOrChi = "Child",
                        Parent = "APC A"
                    },
                    new Qualification
                    {
                        QualName = "APC A- FC",
                        ParOrChi = "Child",
                        Parent = "APC A"
                    },
                    new Qualification
                    {
                        QualName = "APC A",
                        ParOrChi = "Parent",
                        NumChi = 4
                    },
                    new Qualification
                    {
                        QualName = "Camp 17"
                    },
                    new Qualification
                    {
                        QualName = "CADSAM 17"
                    },
                    new Qualification
                    {
                        QualName = "Sept FW17"
                    },
                    new Qualification
                    {
                        QualName = "Nov FW17"
                    },
                    new Qualification
                    {
                        QualName = "Eley Shot 18"
                    },
                    new Qualification
                    {
                        QualName = "Sen Feb FW18"
                    },
                    new Qualification
                    {
                        QualName = "Camp 18"
                    },
                    new Qualification
                    {
                        QualName = "CADSAM 18"
                    },
                    new Qualification
                    {
                        QualName = "FW22 to 23Sep2018"
                    },
                    new Qualification
                    {
                        QualName = "NovFW18"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
