using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.SwitchCaseStatement
{
    static class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            switch (x)
            {
                case 6:
                    Console.WriteLine("X is 6");
                    Console.ReadLine();
                    break;
                case 5:
                case 7:
                    Console.WriteLine("X is either 5 or 7");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("X was not found");
                    Console.ReadLine();
                    break;
            }

            //if (x == 6)
            //{
            //    Console.WriteLine("X is 6");
            //    Console.ReadLine();
            //}
            //else if (x == 5)
            //{
            //    Console.WriteLine("X is 5");
            //    Console.ReadLine();
            //}
            //else if (x == 7)
            //{
            //    Console.WriteLine("X is 7");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("The condition is false!");
            //    Console.ReadLine();
            //}
        }
    }
}
