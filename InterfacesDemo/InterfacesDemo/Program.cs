using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle buick = new Vehicle("Buick", 4, 160);

            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine($"The {buick.Brand} can't be driven");
            }

            IElectronicDevice TV = TvRemote.GetDevice();

            PowerButton powerButton = new PowerButton(TV);

            powerButton.Execute();
            powerButton.Undo();

            Console.ReadLine();
        }
    }
}
