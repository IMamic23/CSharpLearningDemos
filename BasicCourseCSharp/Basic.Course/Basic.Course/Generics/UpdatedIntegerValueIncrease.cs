using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Generics
{
    class UpdatedIntegerValueIncrease : IValueIncrease<int>
    {
        public int Value1 { get; set; }

        public int Value2 { get; set; }

        public UpdatedIntegerValueIncrease(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public int Product()
        {
            return Value2 * Value1;
        }

        public int Sum()
        {
            return Value2 + Value1;
        }
    }
}
