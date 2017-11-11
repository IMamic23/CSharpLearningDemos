using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Abstraction
{
    abstract class AdditionClass
    {
        abstract public object Total { get; }
        abstract protected object AddTwoValues(object Value1, object Value2);
    }
}
