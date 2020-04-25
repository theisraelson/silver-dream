﻿using System;
using SilverDream.Battles.Characters;
using SilverDream.Battles.Costs;
using SilverDream.Battles.SkillEffects;

namespace SilverDream.Battles.Skills
{
    public abstract class DamageSkill : Skill
    {
        protected DamageSkill(string name, Cost cost, double skillStrength) :
            base(name, cost, skillStrength)
        { }

        protected double GetDamageAmount(Character user, Character receiver, double SkillStrength, double magicOrPhysicalStat)
        {
            Stats uStats = user.Stats;
            Stats rStats = receiver.Stats;
            double lvlDifference = uStats.Level / rStats.Level;
            double random = GetRandomMultiplier();

            double amount = (5 * Math.Sqrt(magicOrPhysicalStat / rStats.Defense * SkillStrength) * lvlDifference * random);

            return amount;
        }

        private static double GetRandomMultiplier()
        {
            Random r = new Random();
            int factor = r.Next(0, 10);

            double dFactor = (double)factor / 100;

            return dFactor + 0.95;
        }
    }
}
