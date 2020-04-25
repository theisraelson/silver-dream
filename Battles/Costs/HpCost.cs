using SilverDream.Battles.Characters;

namespace SilverDream.Battles.Costs
{
    public class HpCost : Cost
    {

        public string Name { get; }

        public int Amount { get; }

        public HpCost(int amount)
        {
            Name = "HP";
            Amount = amount;
        }

        public void UseCost(Character user)
        {
            user.Stats.Hp -= Amount;
        }
    }
}