using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.MethodOverloadingAndSignatures
{
    static class Program
    {
        static void Main(string[] args)
        {
            MyClass MyObject = new MyClass();

            //MyObject.Value1 = 4;
            //MyObject.Value2 = 8;
            //MyObject.doMath();
            Console.WriteLine(MyObject.doMath(5, 9, 11));
            Console.ReadLine();
        }

    }
}
