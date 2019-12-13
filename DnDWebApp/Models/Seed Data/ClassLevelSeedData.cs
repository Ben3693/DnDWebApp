using DnDWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWebApp.Models.SeedData
{
    public static class ClassLevelSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DnDContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DnDContext>>()))
            {
                // Look for any Class Levels.
                if (context.ClassLevel.Any())
                {
                    return;   // DB has been seeded
                }

                context.ClassLevel.AddRange(

                    // Barbarian
                    
                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 1,
                        Features = "Rage, Unarmored Defense, Rage Damage +2"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 2,
                        Features = "Reckless Attack, Danger Sense"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 3,
                        Features = "Primal Path"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 4,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 5,
                        Features = "Extra Attack, Fast Movement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 6,
                        Features = "Path feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 7,
                        Features = "Feral Instinct"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 8,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 9,
                        Features = "Brutal Critical (1 die), Rage Damage +3"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 10,
                        Features = "Path feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 11,
                        Features = "Relentless Rage"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 12,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 13,
                        Features = "Brutal Critical (2 dice)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 14,
                        Features = "Path feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 15,
                        Features = "Persistent Rage"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 16,
                        Features = "Ability Score Improvement, Rage Damage +4"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 17,
                        Features = "Brutal Critical (3 dice)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 18,
                        Features = "Indomitable Might"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 19,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Barbarian",
                        HitDice = "d12",
                        Level = 20,
                        Features = "Primal Champion"
                    },

                    // Bard

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 1,
                        Features = "Spellcasting, Bardic Inspiration (d6)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 2,
                        Features = "Jack of All Trades, Song of Rest (d6)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 3,
                        Features = "Bard College, Expertise"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 4,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 5,
                        Features = "Bardic Inspiration (d8), Font of Inspiration"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 6,
                        Features = "Countercharm, Bard College feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 7,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 8,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 9,
                        Features = "Song of Rest (d8)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 10,
                        Features = "Bardic Inspiration (d10), Expertise, Magical Secrets"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 11,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 12,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 13,
                        Features = "Song of Rest (d10)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 14,
                        Features = "Magical Secrets, Bard College feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 15,
                        Features = "Bardic Inspiration (d12)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 16,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 17,
                        Features = "Song of Rest (d12)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 18,
                        Features = "Magical Secrets"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 19,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Bard",
                        HitDice = "d8",
                        Level = 20,
                        Features = "Superior Inspiration"
                    },

                    // Cleric

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 1,
                        Features = "Spellcasting, Divine Domain"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 2,
                        Features = "Channel Divinity (1/rest), Divine Domain feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 3,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 4,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 5,
                        Features = "Destroy Undead (CR 1/2)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 6,
                        Features = "Channel Divinity (2/rest), Divine Domain feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 7,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 8,
                        Features = "Ability Score Improvement, Destroy Undead (CR 1), Divine Domain feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 9,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 10,
                        Features = "Divine Intervention"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 11,
                        Features = "Destroy Undead (CR 2)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 12,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 13,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 14,
                        Features = "Destroy Undead (CR 3)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 15,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 16,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 17,
                        Features = "Destroy Undead (CR 4), Divine Domain feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 18,
                        Features = "Channel Divinity (3/rest)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 19,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Cleric",
                        HitDice = "d8",
                        Level = 20,
                        Features = "Divine Intervention improvement"
                    },

                    // Druid

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 1,
                        Features = "Druidic, Spellcasting"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 2,
                        Features = "Wild Shape, Druid Circle"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 3,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 4,
                        Features = "Wild Shape improvement, Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 5,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 6,
                        Features = "Druid Circle feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 7,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 8,
                        Features = "Wild Shape improvement, Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 9,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 10,
                        Features = "Druid Circle feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 11,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 12,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 13,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 14,
                        Features = "Druid Circle feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 15,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 16,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 17,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 18,
                        Features = "Timeless Body, Beast Spells"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 19,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Druid",
                        HitDice = "d8",
                        Level = 20,
                        Features = "Archdruid"
                    },

                    // Fighter

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
                    },

                    // Monk

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 1,
                        Features = "Unarmored Defense, Martial Arts 1d4"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 2,
                        Features = "Ki, Unarmored Movement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 3,
                        Features = "Monastic Tradition, Deflect Missiles"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 4,
                        Features = "Ability Score Improvement, Slow Fall"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 5,
                        Features = "Extra Attack, Stunning Strike, Martial Arts 1d6"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 6,
                        Features = "Ki-Empowered Strikes, Monastic Tradition feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 7,
                        Features = "Evasion, Stillness of Mind"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 8,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 9,
                        Features = "Unarmored Movement improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 10,
                        Features = "Purity of Body"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 11,
                        Features = "Monastic Tradition feature, Martial Arts 1d8"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 12,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 13,
                        Features = "Tongue of the Sun and Moon"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 14,
                        Features = "Diamond Soul"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 15,
                        Features = "Timeless Body"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 16,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 17,
                        Features = "Monastic Tradition feature, Martial Arts 1d10"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 18,
                        Features = "Empty Body"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 19,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Monk",
                        HitDice = "d8",
                        Level = 20,
                        Features = "Perfect Self"
                    },

                    // Paladin

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 1,
                        Features = "Divine Sense, Lay on Hands"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 2,
                        Features = "Fighting Style, Spellcasting, Divine Smite"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 3,
                        Features = "Divine Health, Sacred Oath"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 4,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 5,
                        Features = "Extra Attack"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 6,
                        Features = "Aura of Protection"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 7,
                        Features = "Sacred Oath feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 8,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 9,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 10,
                        Features = "Aura of Courage"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 11,
                        Features = "Improved Divine Smite"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 12,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 13,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 14,
                        Features = "Cleansing Touch"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 15,
                        Features = "Sacred Oath feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 16,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 17,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 18,
                        Features = "Aura improvements"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 19,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Paladin",
                        HitDice = "d10",
                        Level = 20,
                        Features = "Sacred Oath feature"
                    },

                    // Ranger

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 1,
                        Features = "Favored Enemy, Natural Explorer"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 2,
                        Features = "Fighting Style, Spellcasting"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 3,
                        Features = "Ranger Archetype, Primeval Awareness"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 4,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 5,
                        Features = "Extra Attack"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 6,
                        Features = "Favored Enemy and Natural Explorer improvements"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 7,
                        Features = "Ranger Archetype feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 8,
                        Features = "Ability Score Improvement, Land’s Stride"
                    },
                    
                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 9,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 10,
                        Features = "Natural Explorer improvement, Hide in Plain Sight"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 11,
                        Features = "Ranger Archetype feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 12,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 13,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 14,
                        Features = "Favored Enemy improvement, Vanish"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 15,
                        Features = "Ranger Archetype feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 16,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 17,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 18,
                        Features = "Feral Senses"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 19,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Ranger",
                        HitDice = "d10",
                        Level = 20,
                        Features = "Foe Slayer"
                    },

                    // Rogue

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 1,
                        Features = "Expertise, Sneak Attack, Thieves’ Cant"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 2,
                        Features = "Cunning Action"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 3,
                        Features = "Roguish Archetype"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 4,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 5,
                        Features = "Uncanny Dodge"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 6,
                        Features = "Expertise"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 7,
                        Features = "Evasion"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 8,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 9,
                        Features = "Roguish Archetype feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 10,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 11,
                        Features = "Reliable Talent"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 12,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 13,
                        Features = "Roguish Archetype feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 14,
                        Features = "Blindsense"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 15,
                        Features = "Slippery Mind"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 16,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 17,
                        Features = "Roguish Archetype feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 18,
                        Features = "Elusive"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 19,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Rogue",
                        HitDice = "d8",
                        Level = 20,
                        Features = "Stroke of Luck"
                    },

                    // Sorcerer

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 1,
                        Features = "Spellcasting, Sorcerous Origin"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 2,
                        Features = "Font of Magic"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 3,
                        Features = "Metamagic"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 4,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 5,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 6,
                        Features = "Sorcerous Origin feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 7,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 8,
                        Features = "Ability Score Improvement 5"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 9,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 10,
                        Features = "Metamagic"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 11,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 12,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 13,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 14,
                        Features = "Sorcerous Origin feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 15,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 16,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 17,
                        Features = "Metamagic"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 18,
                        Features = "Sorcerous Origin feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 19,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Sorcerer",
                        HitDice = "d6",
                        Level = 20,
                        Features = "Sorcerous Restoration"
                    },

                    // Warlock

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 1,
                        Features = "Otherworldly Patron, Pact Magic"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 2,
                        Features = "Eldritch Invocations"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 3,
                        Features = "Pact Boon"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 4,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 5,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 6,
                        Features = "Otherworldly Patron feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 7,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 8,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 9,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 10,
                        Features = "Otherworldly Patron feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 11,
                        Features = "Mystic Arcanum (6th level)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 12,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 13,
                        Features = "Mystic Arcanum (7th level)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 14,
                        Features = "Otherworldly Patron feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 15,
                        Features = "Mystic Arcanum (8th level)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 16,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 17,
                        Features = "Mystic Arcanum (9th level)"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 18,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 19,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Warlock",
                        HitDice = "d8",
                        Level = 20,
                        Features = "Eldritch Master"
                    },

                    // Wizard
                    
                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 1,
                        Features = "Spellcasting, Arcane Recovery"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 2,
                        Features = "Arcane Tradition"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 3,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 4,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 5,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 6,
                        Features = "Arcane Tradition feature 4 4"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 7,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 8,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 9,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 10,
                        Features = "Arcane Tradition feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 11,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 12,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 13,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 14,
                        Features = "Arcane Tradition feature"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 15,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 16,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 17,
                        Features = "—"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 18,
                        Features = "Spell Mastery"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 19,
                        Features = "Ability Score Improvement"
                    },

                    new ClassLevel
                    {
                        ClassName = "Wizard",
                        HitDice = "d6",
                        Level = 20,
                        Features = "Signature Spell"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
