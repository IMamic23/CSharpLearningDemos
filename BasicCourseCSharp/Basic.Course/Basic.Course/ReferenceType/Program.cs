using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.ReferenceType
{
    static class Program
    {
        static void Main(string[] args)
        {
            //int x = 7;
            //int y = x;

            //y++;

            //Console.WriteLine(x);
            //Console.ReadLine();

            MyClass MyObject = new MyClass(8, 3);

            MyClass MyObject2 = MyObject;

            MyObject2.Value1 = 100;

            MyObject.doMath();

        }

    }
}
