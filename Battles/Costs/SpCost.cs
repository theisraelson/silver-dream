using SilverDream.Battles.Characters;

namespace SilverDream.Battles.Costs
{
    public class SpCost : Cost
    {

        public string Name { get; }

        public int Amount { get; }

        public SpCost(int amount)
        {
            Name = "SP";
            Amount = amount;
        }

        public void UseCost(Character user)
        {
            user.Stats.Sp -= Amount;
        }
    }
}