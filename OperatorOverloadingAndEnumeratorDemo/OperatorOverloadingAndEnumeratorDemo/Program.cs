﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAndEnumeratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFarm myAnimas = new AnimalFarm();
            myAnimas[0] = new Animal("Wilbur");
            myAnimas[1] = new Animal("Roza");
            myAnimas[2] = new Animal("Gander");
            myAnimas[3] = new Animal("Charlotte");

            foreach (Animal animal in myAnimas)
            {
                Console.WriteLine(animal.Name);
            }

            Console.WriteLine("Operator overloading");
            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(5, 6, 7);

            Box box3 = box1 + box2;
            Console.WriteLine($"\n(+) Box3: {box3}");

            Console.WriteLine($"\nBox Int: {(int)box3}");

            Box box4 = (Box) 4;
            Console.WriteLine($"\nBox 4 from int: {(Box)4}");

            var shopkins = new {Name = "Shopkins", Price = 4.99};
            Console.WriteLine($"\n{shopkins.Name} costs ${shopkins.Price}");

            var toyArray = new[]
            {
                new {Name = "Yo-Kai Pack", Price = 4.99},
                new {Name = "Legos", Price = 9.99}
            };

            foreach (var toy in toyArray)
            {
                Console.WriteLine($"{toy.Name} costs ${toy.Price}");
            }

            Console.ReadLine();
        }
    }
}
