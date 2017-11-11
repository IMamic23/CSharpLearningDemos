using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Generics
{
    public interface IValue2Property<T>
    {
        T Value2 { get; set; }
    }
}
