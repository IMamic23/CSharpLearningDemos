using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.Inheritance
{
    static class Program
    {
        static void Main(string[] args)
        {
            MyClass MyObject = new MyAdditionClass(5, 7);

            Console.WriteLine(MyObject.Total);
            Console.ReadLine();
        }

    }
}
