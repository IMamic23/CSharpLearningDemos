using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePoliymorphysm
{
    class Square : Drawing
    {
        public override void Draw()
        {
            Console.WriteLine("This is a square");
        }
    }
}
