using SilverDream.Battles.Skills;

namespace SilverDream.Battles.Characters
{
    public interface Character
    {
        string Name { get; set; }
        Stats Stats { get; set; }
        SkillList SkillList { get; set; }
    }
}