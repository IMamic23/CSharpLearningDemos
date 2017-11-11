using System;

namespace WarriorsOOPGame
{
    internal class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        private Random _rnd = new Random();

        public Warrior(string name = "Warrior", double health = 0, double attackMax = 0, double blockMax = 0 )
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        // Attack
        public double Attack()
        {
            return _rnd.Next(1, (int) AttackMax);
        }

        // Block
        public double Block()
        {
            return _rnd.Next(1, (int) BlockMax);
        }

    }
}
