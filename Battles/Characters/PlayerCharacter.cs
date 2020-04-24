using SilverDream.Battles.Skills;

namespace SilverDream.Battles.Characters
{
    public class PlayerCharacter : Character
    {
        public string Name { get; }
        public Stats Stats { get; set; }
        public SkillList SkillList { get; set; }

        public PlayerCharacter(string name, Stats stats, SkillList skillList)
        {
            Name = name;
            Stats = stats;
            SkillList = skillList;
        }

        public override string ToString()
        {
            string output = "";
            output += string.Format("Name: {0}\nHP: {1}\nSP: {2}", Name, Stats.Hp, Stats.Sp);
            return output;
        }
    }
}
