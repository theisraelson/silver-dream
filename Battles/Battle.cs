using System.Collections.Generic;
using SilverDream.Battles.Characters;
using SilverDream.Battles.Skills;

namespace SilverDream.Battles
{
    public class Battle
    {
        public List<Character> Allies { get; set; }
        public List<Character> Enemies { get; set; }

        public Battle(List<Character> allies, List<Character> enemies)
        {
            Allies = allies;
            Enemies = enemies;
        }

        public void UseSkill(Skill skill, Character user, Character receiver)
        {
            skill.UseCost(user);
            skill.ApplySkill(user, receiver);
        }

        public override string ToString()
        {
            string output = "";

            output += "-------------------------\n";
            output += Allies[0].ToString();
            output += "\n";
            output += "\n";

            output += Enemies[0].ToString();
            output += "\n-------------------------\n";

            return output;
        }
    }
}
