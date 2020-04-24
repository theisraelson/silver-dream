namespace SilverDream.Battles.Characters
{
    public class Stats
    {
        public int Level { get; set; }
        public int XP { get; set; }
        public int Speed { get; set; }
        public int Power { get; set; }
        public int Defense { get; set; }
        public int Finesse { get; set; }
        public int Luck { get; set; }

        public Stats()
        {
            Level = 0;
            XP = 0;
            Speed = 0;
            Power = 0;
            Defense = 0;
            Finesse = 0;
            Luck = 0;
        }
    }
}
