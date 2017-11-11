using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.Encapsulation
{
    static class Program
    {
        static void Main(string[] args)
        {
            MyClass MyObject = new MyClass(5, 7);

            Console.WriteLine(MyObject.Total);
            Console.ReadLine();
        }

    }
}
