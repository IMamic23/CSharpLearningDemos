using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.MethodOverloadingAndSignatures
{
    class MyClass
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }

        public void doMath()
        {
            Console.WriteLine(addTwoIntegers(this.Value1, Value2));
            Console.ReadLine();
        }
        public int doMath(int value1, int value2)
        {
            return addTwoIntegers(value1, value2);
        }
        public int doMath(int value1, int value2, int maxTotal)
        {
            int total = addTwoIntegers(value1, value2);
            if (total > maxTotal) total = maxTotal;
            return total;
        }
        private int addTwoIntegers(int value1, int value2 = 0)
        {
            int sum = value1 + value2;
            return sum;
        }
    }
}
