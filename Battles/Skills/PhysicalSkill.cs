﻿using System;
using SilverDream.Battles.Characters;
using SilverDream.Battles.Costs;
using SilverDream.Battles.SkillEffects;

namespace SilverDream.Battles.Skills
{
    public class PhysicalSkill : DamageSkill
    {
        public PhysicalSkill(string name, Cost cost, double skillStrength) :
            base(name, cost, skillStrength)
        { }

        public override void ApplySkill(Character user, params Character[] receivers)
        {
            foreach(Character c in receivers)
            {
                c.Stats.Hp -= GetDamageAmount(user, c, SkillStrength, user.Stats.Physical);
            }
        }
    }
}
