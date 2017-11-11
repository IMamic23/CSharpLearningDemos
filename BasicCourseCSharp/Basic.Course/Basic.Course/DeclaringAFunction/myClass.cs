using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.DeclaringAFunction
{
    class MyClass
    {
        public void doMath()
        {
            Console.WriteLine(addTwoIntegers(2));
            Console.ReadLine();
        }
        private int addTwoIntegers(int value1, int value2 = 0)
        {
            int sum = value1 + value2;
            return sum;
        }
    }
}
