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
        public DnDContext(DbContextOptions<DnDContext> options)
            : base(options)
        {
        }
        public DbSet<ClassLevel> ClassLevel { get; set; }
        public DbSet<ClassFeature> ClassFeature { get; set; }
    }
}
