using System;
using SilverDream.Battles.Characters;

namespace SilverDream.Battles.SkillEffects
{
    public class SkillEffect
    {
        double EffectStrength;
        //still need to implement Character states. ex: asleep, confused, etc.
        //State state;

        public SkillEffect(double effectStrength)
        {
            EffectStrength = effectStrength;
            //State state = new DefaultState();
        }

        public void ApplyEffect(Character user, Character receiver)
        {
            //receiver.State = State
        }
    }
}
