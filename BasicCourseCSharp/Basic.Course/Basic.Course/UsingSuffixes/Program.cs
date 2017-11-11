using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.UsingSuffixes
{
    static class Program
    {
        static void Main(string[] args)
        {
            //string displayText = "Hello World!";
            //int displayInt = 23;
            //double displayDouble = 25.003239834892374;
            //decimal displayDecimal = 36.435234523M;
            long displayLong = 4131234324543L;

            Console.WriteLine(displayLong);

            Debug.WriteLine(displayLong);
            //Debug.WriteLine(displayInt.Count());
            Console.ReadLine();
        }
    }
}
