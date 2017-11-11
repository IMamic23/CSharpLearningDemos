using System;

namespace WarriorsOOPGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var kudi = new Warrior("Kudi", health: 1000, attackMax: 80, blockMax: 40);
            var neven = new Warrior("Neven", health: 1000, attackMax: 70, blockMax: 45);

            Battle.StartFight(kudi, neven);

            Console.ReadLine();
        }
    }
}
