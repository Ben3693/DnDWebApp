using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWebApp.Business
{
    public class WeaponAttack
    {
        public double AverageDamage(string weaponDice = "d8", int ac = 20, int proficiency = 6, int abilityMod = 5, int magicWeapon = 0)
        {
            // Hits when d20 roll=ac, so chance is 1-(ac-1)/20+(mods)/20 = (20-ac+1+mods)/20 = (21+mods-ac)/20. "21.0" forces floating point division.
            // Capped between 1 and 0, so Max(0, chance) and Min(1, chance)
            double ChanceToHit = Math.Min(1, Math.Max(0, (21.0 + proficiency + abilityMod + magicWeapon - ac) / 20));
            
            // Extract number from weaponDice and convert to double:
            // Find "d"
            int i = weaponDice.IndexOf("d");
            // Extract number of dice and number of sides from expression and convert to doubles.
            double dice = Convert.ToDouble(weaponDice.Substring(i + 1));
            double sides = Convert.ToDouble(weaponDice.Substring(0, i));

            // Average damage roll is M(N+1)/2 for MdN, plus modifiers. Average overall damage is this times chance to hit.
            return ChanceToHit * dice * (sides + 1) / 2 + abilityMod + magicWeapon;
        }
    }
}
