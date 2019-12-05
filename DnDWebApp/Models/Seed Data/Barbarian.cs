using DnDWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWebApp.Models.Seed_Data
{
    public class Barbarian
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DnDContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DnDContext>>()))
            {
                // Look for any Barbarian Levels.
                if (context.ClassLevel.Any())
                {
                    return;   // DB has been seeded
                }

                context.ClassLevel.AddRange(
                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 1,
                        Features = "Rage, Unarmored Defense"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
