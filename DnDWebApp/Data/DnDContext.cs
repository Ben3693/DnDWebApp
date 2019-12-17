using DnDWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWebApp.Data
{
    public class DnDContext : DbContext
    {
        public DnDContext()
        {
        }

        public DnDContext(DbContextOptions<DnDContext> options)
            : base(options)
        {
        }
        public DbSet<ClassLevel> ClassLevel { get; set; }
        public DbSet<ClassFeature> ClassFeature { get; set; }
        public static ClassLevel GetClassLevel(string className, int classLevel)
        {
            using (var context = new DnDContext())
            {
                return (from l in context.ClassLevel where (l.ClassName == className) && (l.Level == classLevel) select l).Single();
            }
        }
    }
}
