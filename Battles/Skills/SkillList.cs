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

        public int GetMaxSkills()
        {
            return list.Capacity;
        }

        public bool add(Skill skill)
        {
            bool output = false;
            if(list.Capacity > list.Count)
            {
                list.Add(skill);
                output = true;
            }
            return output;
        }

        public Skill GetSkillAt(int index)
        {
            return list[index];
        }
    }
}
