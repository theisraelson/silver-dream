using System.Collections.Generic;

namespace SilverDream.Battles.Skills
{
    public class SkillList
    {
        private List<Skill> list;

        public SkillList(int maxSkills)
        {
            list = new List<Skill>(maxSkills);
        }

        public int getMaxSkills()
        {
            return list.Capacity;
        }
    }
}
