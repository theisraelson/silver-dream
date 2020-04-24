using System;
using SilverDream.Battles.Characters;

namespace SilverDream.Battles.Skills
{
    public class Sp : Cost
    {

        public string Name { get; }

        public int Cost { get; }

        public Sp(int cost)
        {
            Name = "SP";
            Cost = cost;
        }

        public void UseCost(Character user)
        {
            user.Stats.Sp -= Cost;
        }
    }
}
