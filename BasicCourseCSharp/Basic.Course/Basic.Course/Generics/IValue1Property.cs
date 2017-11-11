using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Generics
{
    public interface IValue1Property<T>
    {
        T Value1 { get; set; }
    }
}
