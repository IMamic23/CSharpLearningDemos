using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyndaInterfacesDemo
{
    class FooBar : IFoo, IBar
    {
        void IFoo.SomeMethod()
        {
            Console.WriteLine("Some Method");
        }

        void IBar.SomeMethod()
        {
            Console.WriteLine("Some Method");
        }
    }
}
