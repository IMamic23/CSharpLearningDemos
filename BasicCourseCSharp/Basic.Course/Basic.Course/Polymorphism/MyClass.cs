using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Polymorphism
{
    class MyClass
    {
        private int _total;
        public virtual int Total
        {
            get { return _total; }
        }

        public MyClass(int Value1, int Value2)
        {
            _total = addTwoIntegers(Value1, Value2);
        }

        protected virtual int addTwoIntegers(int value1, int value2 = 0)
        {
            int sum = value1 + value2;
            return sum;
        }
    }
}
