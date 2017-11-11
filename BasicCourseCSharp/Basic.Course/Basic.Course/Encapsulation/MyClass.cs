using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Encapsulation
{
    class MyClass
    {
        //public int Value1 { get; set; }
        //public int Value2 { get; set; }

        private int _total;

        public int Total
        {
            get { return _total; }
            //set { _total = value; }
        }


        public MyClass(int Value1, int Value2)
        {
            _total = addTwoIntegers(Value1, Value2);

            //this.Value1 = Value1;
            //this.Value2 = Value2;
        }

        //public void doMath()
        //{
        //    Console.WriteLine(addTwoIntegers(this.Value1, Value2));
        //    Console.ReadLine();
        //}
        //public int doMath(int value1, int value2)
        //{
        //    return addTwoIntegers(value1, value2);
        //}
        //public int doMath(int value1, int value2, int maxTotal)
        //{
        //    int total = addTwoIntegers(value1, value2);
        //    if (total > maxTotal) total = maxTotal;
        //    return total;
        //}
        private int addTwoIntegers(int value1, int value2 = 0)
        {
            int sum = value1 + value2;
            return sum;
        }
    }
}
