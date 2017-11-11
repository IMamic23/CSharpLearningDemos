using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.Collections
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int x = 0;

            for (int i = 0; i < 100; i++)
            {
                numbers.Add(i);
            }

            foreach (int item in numbers)
            {
                x += item;
            }

            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
