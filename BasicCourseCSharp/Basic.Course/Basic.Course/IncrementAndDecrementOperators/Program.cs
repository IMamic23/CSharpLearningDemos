using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.IncrementAndDecrementOperators
{
    static class Program
    {
        static void Main(string[] args)
        {



            ////Incremental Operator
            //Console.WriteLine(++a);
            //Console.WriteLine(a);

            //Console.WriteLine(a++);
            //Console.WriteLine(a);

            //a++;
            //Console.WriteLine(a);
            //++a;
            //Console.WriteLine(a);

            int a = 10;

            ////Decremental Operator
            //Console.WriteLine(--a);
            //Console.WriteLine(a);

            //Console.WriteLine(a--);
            //Console.WriteLine(a);

            a--;
            Console.WriteLine(a);
            --a;
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
