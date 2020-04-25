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
        public SkillEffect Effect { get; }
        public double SkillStrength { get; }

        public abstract void ApplySkill(Character user, Character receiver);

        public Skill(string name, Cost cost, SkillEffect effect, double skillStrength)
        {
            Name = name;
            Cost = cost;
            Effect = effect;
            SkillStrength = skillStrength;
        }

        public void UseCost(Character user)
        {
            Cost.UseCost(user);
        }
    }
}
