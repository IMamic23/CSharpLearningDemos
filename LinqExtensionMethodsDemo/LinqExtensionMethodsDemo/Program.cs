using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExtensionMethodsDemo
{
    class Program
    {
        delegate double DoubleIt(double val);

        static void Main(string[] args)
        {
            DoubleIt dblIt = x => x * 2;
            Console.WriteLine($"5 * 2 = {dblIt(5)}");

            List<int> numList = new List<int> { 1, 9, 2, 6, 3, 4, 12 };

            var evenList = numList.Where(a => a % 2 == 0).ToList();

            Console.WriteLine("\nEven numbers");
            foreach (var num in evenList)
                Console.WriteLine(num);

            var rangeList = numList.Where(x => (x > 2) && (x < 9)).ToList();

            Console.WriteLine("\nNumbers between 2 and 9");
            foreach (var num in rangeList)
                Console.WriteLine(num);

            List<int> flipList = new List<int>();

            int i = 0;
            Random rnd = new Random();
            while (i < 100)
            {
                flipList.Add(rnd.Next(1, 3));
                i++;
            }

            Console.WriteLine($"Heads: {flipList.Where(a => a == 1).ToList().Count}");
            Console.WriteLine($"Tails: {flipList.Where(a => a == 2).ToList().Count}");

            // STARTS WITH

            var nameList = new List<string> { "Doug", "Sally", "Sou", "Dukica", "Maminjo" };

            var sNameList = nameList.Where(x => x.StartsWith("S"));

            Console.WriteLine("\nNames starting with 'S'");
            foreach (var name in sNameList)
                Console.WriteLine(name);

            // SELECT

            var oneTo10 = new List<int>();
            oneTo10.AddRange(Enumerable.Range(1, 10));

            var squares = oneTo10.Select(x => x * x).ToList();

            Console.WriteLine("\nSquare values of integers");
            foreach (var square in squares)
                Console.WriteLine(square);

            // ZIP

            var listOne = new List<int>(new int[] { 1, 3, 4 });
            var listTwo = new List<int>(new int[] { 4, 6, 8 });

            var sumList = listOne.Zip(listTwo, (x, y) => x + y).ToList();

            Console.WriteLine("\nZip on two lists");

            foreach (var i1 in sumList)
                Console.WriteLine(i1);

            // AGGREGATE
            var numList2 = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("\nComplete list: {0}", string.Join(", ", numList2));
            Console.WriteLine("Sum: {0}", numList2.Aggregate((a, b) => a + b));

            // AVERAGE
            var numList3 = new List<int>() { 7, 12, 3, 4, 5 };
            Console.WriteLine("\nComplete list: {0}", string.Join(", ", numList3));
            Console.WriteLine("Average: {0}", numList3.AsQueryable().Average());

            // ALL
            Console.WriteLine("\nComplete list: {0}", string.Join(", ", numList3));
            Console.WriteLine("All Greater then 3? {0}", numList3.All(x => x > 3));

            // ANY
            Console.WriteLine("\nComplete list: {0}", string.Join(", ", numList3));
            Console.WriteLine("Any greater then 3? {0}", numList3.Any(x => x > 3));

            // DISTINCT
            var numList4 = new List<int>() { 7, 11, 12, 7, 3, 4, 3, 5 };
            Console.WriteLine("\nComplete list: {0}", string.Join(", ", numList4));
            Console.WriteLine("Distinct {0}", string.Join(", ", numList4.Distinct()));

            // EXCEPT
            var numList5 = new List<int>() { 7, 11, 12, 7, 3, 4, 3, 5 };
            var numList6 = new List<int>() { 7, 4, 5 };
            Console.WriteLine("\nComplete list 1: {0}", string.Join(", ", numList5));
            Console.WriteLine("Complete list 2: {0}", string.Join(", ", numList6));
            Console.WriteLine("Except: {0}", string.Join(", ", numList5.Except(numList6)));

            // INTERSECT
            Console.WriteLine("\nComplete list 1: {0}", string.Join(", ", numList5));
            Console.WriteLine("Complete list 2: {0}", string.Join(", ", numList6));
            Console.WriteLine("Intersect: {0}", string.Join(", ", numList5.Intersect(numList6)));

            Console.ReadLine();
        }
    }
}
