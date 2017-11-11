using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.DeclaringAProperty
{
    class MyClass
    {
        private int _value1;
        private int _value2;

        public int Value1
        {
            get { return _value1; }
            set { _value1 = value; }
        }
        public int Value2
        {
            set { _value2 = value; }
        }

        public void doMath()
        {
            Console.WriteLine(addTwoIntegers(this.Value1, _value2));
            Console.ReadLine();
        }
        private int addTwoIntegers(int value1, int value2 = 0)
        {
            int sum = value1 + value2;
            return sum;
        }
    }
}
