using SilverDream.Battles.Characters;

namespace SilverDream.Battles.Skills
{
    public interface Skill
    {
        string Name { get; }
        Cost Cost { get; }
        void UseCost(Character user);
        void ApplyEffect(Character user, Character receiver);
    }


}
