using System;
using SilverDream.Battles.Characters;
using SilverDream.Battles.Costs;
using SilverDream.Battles.SkillEffects;

namespace SilverDream.Battles.Skills
{
    public class HealingSkill : Skill
    {
        public HealingSkill(String name, Cost cost, SkillEffect effect, double skillStrength) :
            base(name, cost, skillStrength)
        { }

        public override void ApplySkill(Character user, params Character[] receivers)
        {
            foreach(Character c in receivers)
            {
                c.Stats.Hp += getHealingAmount(c, SkillStrength);
            }
        }

        public double getHealingAmount(Character receiver, double SkillStrength)
        {
            return receiver.Stats.Hp / (SkillStrength / 100);
        }
    }
}