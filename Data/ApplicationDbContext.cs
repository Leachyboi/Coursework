using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CCFTracker.DataModel;

namespace CCFTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CCFTracker.DataModel.Qualification> Qualification { get; set; }
        public DbSet<CCFTracker.DataModel.Cadet> Cadet { get; set; }
    }
}
