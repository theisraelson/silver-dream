using SilverDream.Battles.Characters;
namespace SilverDream.Battles.Skills
{
    public interface Cost
    {
        string Name { get; }
        int Cost { get; }
        void UseCost(Character user);
    }
}
