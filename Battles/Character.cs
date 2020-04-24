using System;
namespace SilverDream
{
    public interface Character
    {
        string Name { get; set; }
        Stats Stats { get; set; }
        SkillList SkillList { get; set; }
    }
}