using SilverDream.Battles.Characters;
namespace SilverDream.Battles.Skills
{
    public interface Cost
    {
        int cost { get; set; }
        void UseCost(Character user);
    }
}
