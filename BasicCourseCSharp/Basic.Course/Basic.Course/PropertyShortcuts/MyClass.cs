using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.PropertyShortcuts
{
    class MyClass
    {
        //public int Value1;
        //public int Value2;
        //private int _value1;
        //private int _value2;

        //public int Value1 { get; set; }
        //public int Value2 { get; set; }

        public int Value1 { get; set; }

        private int _value2;

        public int Value2
        {
            get { return _value2; }
            set { _value2 = value; }
        }


        public void doMath()
        {
            Console.WriteLine(addTwoIntegers(this.Value1, Value2));
            Console.ReadLine();
        }
        private int addTwoIntegers(int value1, int value2 = 0)
        {
            int sum = value1 + value2;
            return sum;
        }
    }
}
