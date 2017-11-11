using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.ArrayVariables
{
    static class Program
    {
        static void Main(string[] args)
        {
            //int[] values;
            //values = new int[3];

            //values[0] = 3;
            //values[1] = 13;
            //values[2] = 34;

            int[] values = new int[3] { 2, 15, 23 };

            Console.WriteLine(values[0] + values[1] - values[2]);
            Console.ReadLine();
        }
    }
}
