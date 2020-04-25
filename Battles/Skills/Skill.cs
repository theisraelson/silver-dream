using System;
using SilverDream.Battles.Characters;
using SilverDream.Battles.Costs;
using SilverDream.Battles.SkillEffects;

namespace SilverDream.Battles.Skills
{
    public abstract class Skill
    {
        public string Name { get; }
        public Cost Cost { get; }
        public double SkillStrength { get; }

        public abstract void ApplySkill(Character user, params Character[] receivers);

        public Skill(string name, Cost cost, double skillStrength)
        {
            Name = name;
            Cost = cost;
            SkillStrength = skillStrength;
        }

        public void UseCost(Character user)
        {
            Cost.UseCost(user);
        }
    }
}
