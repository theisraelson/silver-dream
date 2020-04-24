using System;
namespace Norman
{
    public interface Character
    {
        string Name { get; set; }
        Stats Stats { get; set; }
        SkillList SkillList { get; set; }
    }
}