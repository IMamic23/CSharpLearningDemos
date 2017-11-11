using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Polymorphism
{
    class MyAdditionClass : MyClass
    {
        private int _total;
        private int _maxTotal;
        public override int Total
        {
            get { return _total; }
        }

        public MyAdditionClass(int value1, int value2, int maxTotal) : base(value1, value2)
        {
            _maxTotal = maxTotal;
            _total = this.addTwoIntegers(value1, value2);
        }
        protected override int addTwoIntegers(int value1, int value2)
        {
           int sum = base.addTwoIntegers(value1, value2);
            if (sum > _maxTotal) sum = _maxTotal;
            return sum;
        }

    }
}
