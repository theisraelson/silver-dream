using SilverDream.Battles.Characters;

namespace SilverDream.Battles.Costs
{
    public interface Cost
    {
        string Name { get; }
        int Amount { get; }
        void UseCost(Character user);
    }
}