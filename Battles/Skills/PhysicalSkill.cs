﻿using System;
using SilverDream.Battles.Characters;
using SilverDream.Battles.Costs;
using SilverDream.Battles.SkillEffects;

namespace SilverDream.Battles.Skills
{
    public class PhysicalSkill : DamageSkill
    {
        public PhysicalSkill(string name, Cost cost, SkillEffect effect, double skillStrength) :
            base(name, cost, effect, skillStrength)
        { }

        public override void ApplySkill(Character user, Character receiver)
        {
            receiver.Stats.Hp -= GetDamageAmount(user, receiver, SkillStrength, user.Stats.Physical);
        }
    }
}
