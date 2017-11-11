using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Course.Generics
{
    public interface IValueIncrease<T> : IValue1Property<T>, IValue2Property<T>, ISumMethod<T>, IProductMethod<T>
    {
    }
}
