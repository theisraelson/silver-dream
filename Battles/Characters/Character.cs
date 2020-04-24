using SilverDream.Battles.Skills;

namespace SilverDream.Battles.Characters
{
    public interface Character
    {
        string Name { get; }
        Stats Stats { get; set; }
        SkillList SkillList { get; set; }
    }
}