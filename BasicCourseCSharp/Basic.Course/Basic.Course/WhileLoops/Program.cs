using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.WhileLoops
{
    static class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (++x < 5)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
