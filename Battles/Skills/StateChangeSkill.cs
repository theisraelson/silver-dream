using System;
using SilverDream.Battles.Characters;
using SilverDream.Battles.Costs;
using SilverDream.Battles.SkillEffects;

namespace SilverDream.Battles.Skills
{
    public interface StateChangeSkill
    {
        public SkillEffect Effect { get; }
        public double EffectChance { get; }

        public bool isEffectApplied()
        {
            Random r = new Random();
            return r.NextDouble() >= EffectChance;
        }
    }
}