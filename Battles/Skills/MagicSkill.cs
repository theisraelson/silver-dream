using System;
using SilverDream.Battles.Characters;

namespace SilverDream.Battles.Skills
{
    public class MagicSkill : Skill
    {

        public string Name { get; }
        public Cost Cost { get; }
        public int Attack { get; }

        public MagicSkill(string name, Cost cost, int attack)
        {
            Name = name;
            Cost = cost;
            Attack = attack;
        }

        public void ApplyEffect(Character user, Character receiver)
        {
            Stats uStats = user.Stats;
            Stats rStats = user.Stats;
            double lvlDifference = uStats.Level / rStats.Level;
            double random = getRandomMultiplier();

            double effect = (5 * Math.Sqrt(uStats.Magic / rStats.Defense * Attack) * lvlDifference * random);

            receiver.Stats.Hp -= effect;

        }

        public static double getRandomMultiplier()
        {
            Random r = new Random();
            int factor = r.Next(0,10);

            double dFactor = (double)factor / 100;

            return dFactor + 0.95;
        }

        public void UseCost(Character user)
        {
            Cost.UseCost(user);
        }
    }
}
