using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.LogicalOperators
{
    static class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            Console.WriteLine( (x > 5 || x < 10) && (x >= 4 && x <= 4) );
            Console.ReadLine();
        }
    }
}
