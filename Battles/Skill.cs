using System;
namespace SilverDream
{
    public interface Skill
    {
        string Name { get; set; }
        Cost Cost { get; set; }
        void UseCost(Character user);
        void ApplyEffect(Character receiver);
    }


}
