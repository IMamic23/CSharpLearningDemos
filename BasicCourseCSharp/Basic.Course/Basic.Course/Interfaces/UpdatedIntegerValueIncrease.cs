using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Interfaces
{
    class UpdatedIntegerValueIncrease : IValueIncrease
    {
        public object Value1 { get; set; }

        public object Value2 { get; set; }

        public UpdatedIntegerValueIncrease(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public object Product()
        {
            return (int)Value2 * (int)Value1;
        }

        public object Sum()
        {
            return (int)Value2 + (int)Value1;
        }
    }
}
