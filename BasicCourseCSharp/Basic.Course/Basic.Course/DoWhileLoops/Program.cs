using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.DoWhileLoops
{
    static class Program
    {
        static void Main(string[] args)
        {
            int x = 6;

            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 6);
            Console.ReadLine();
        }
    }
}
