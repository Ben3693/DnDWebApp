using DnDWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWebApp.Models.SeedData
{
    public static class Fighter
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DnDContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DnDContext>>()))
            {
                // Look for any Fighter Levels.
                if (context.ClassLevel.Any())
                {
                    return;   // DB has been seeded
                }

                context.ClassLevel.AddRange(
                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 1,
                        Features = "Fighting Style, Second Wind"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 2,
                        Features = "Action Surge (one use)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 3,
                        Features = "Martial Archetype"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 4,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 5,
                        Features = "Extra Attack"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 6,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 7,
                        Features = "Martial Archetype feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 8,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 9,
                        Features = "Indomitable (one use)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 10,
                        Features = "Martial Archetype feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 11,
                        Features = "Extra Attack (2)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 12,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 13,
                        Features = "Indomitable (two uses)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 14,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 15,
                        Features = "Martial Archetype feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 16,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 17,
                        Features = "Action Surge (two uses), Indomitable (three uses)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 18,
                        Features = "Martial Archetype feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 19,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Fighter",
                        HitDice = "d10",
                        Level = 20,
                        Features = "Extra Attack (3)"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
