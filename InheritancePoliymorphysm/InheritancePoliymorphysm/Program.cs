using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePoliymorphysm
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestAnimal();

            //TestDrawing();

            TestAbstract();
        }

        public static void TestAbstract()
        {
            Shape[] shapes = {new Circle2(5), new Rectangle(4,5) };

            foreach (var shape in shapes)
            {
                shape.GetInfo();

                Console.WriteLine($"{shape.Name} Area: {shape.Area():f2} ");

                Circle2 testCirc = shape as Circle2;
                if (testCirc == null)
                    Console.WriteLine("This is not a Circle");

                if(shape is Circle2)
                    Console.WriteLine("This is not a Rectangle");

                Console.WriteLine();

                object circ1 = new Circle2(4);
                Circle2 circ2 = (Circle2)circ1;
                Console.WriteLine($"The {circ2.Name} Area is {circ2.Area():f2}");
            }

            Console.ReadLine();
        }

        public static void TestAnimal()
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog lotta = new Dog()
            {
                Name = "Lotta",
                Sound = "Woof",
                Sound2 = "Grrrrrrr"
            };

            lotta.Sound = "Wooooooooooof";

            whiskers.MakeSound();
            lotta.MakeSound();

            whiskers.SetAnimalIdInfo(13, "Duda Mamic");
            lotta.SetAnimalIdInfo(14, "Ivica Mamic");

            whiskers.GetAnimalIdInfo();
            lotta.GetAnimalIdInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();

            Console.WriteLine("Is my animal healthy: {0}", getHealth.HealthyWeight(11, 46));

            Animal monkey = new Animal()
            {
                Name = "Bobo",
                Sound = "Eeeeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Woooofffff",
                Sound2 = "Geeeeerrrrr"
            };

            monkey.MakeSound();
            spot.MakeSound();

            Console.ReadLine();
        }
        public static void TestDrawing()
        {
            Drawing[] drawObj = new Drawing[4];

            drawObj[0] = new Line();
            drawObj[1] = new Circle();
            drawObj[2] = new Square();
            drawObj[3] = new Drawing();

            foreach (var drawing in drawObj)
            {
                drawing.Draw();
            }

            Console.ReadLine();
        }
    }
}
