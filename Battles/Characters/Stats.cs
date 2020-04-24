namespace SilverDream.Battles.Characters
{
    public class Stats
    {
        public double Hp { get; set; }
        public double Sp { get; set; }
        public double Level { get; set; }
        public double Xp { get; set; }
        public double Speed { get; set; }
        public double Power { get; set; }
        public double Defense { get; set; }
        public double Magic { get; set; }
        public double Luck { get; set; }

        public Stats(double hp, double sp, double level, double xp, double speed, double power, double defense, double magic, double luck)
        {
            Hp = hp;
            Sp = sp;
            Level = level;
            Xp = xp;
            Speed = speed;
            Power = power;
            Defense = defense;
            Magic = magic;
            Luck = luck;
        }

        public void RemoveHp(double hp)
        {
            Hp -= hp;

            if (Hp < 0)
            {
                Hp = 0;
            }
        }
    }
}
