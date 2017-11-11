using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.Interfaces
{
    static class Program
    {
        static void Main(string[] args)
        {
            IValueIncrease MyMath = new UpdatedIntegerValueIncrease(7, 8);
        }
    }
}
