using SilverDream.Battles.Skills;

namespace SilverDream.Battles.Characters
{
    public class PlayerCharacter : Character
    {
        public string Name { get; set; }
        public Stats Stats { get; set; }
        public SkillList SkillList { get; set; }

        public PlayerCharacter(string name, Stats stats, SkillList skillList)
        {
            Name = name;
            Stats = stats;
            SkillList = skillList;
        }


    }
}
