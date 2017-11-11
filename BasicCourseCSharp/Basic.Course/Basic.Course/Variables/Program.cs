using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.Variables
{
    static class Program
    {
        static void Main(string[] args)
        {
            string displayText = "Hello World!";

            Console.WriteLine(displayText);

            Debug.WriteLine(displayText);
            Debug.WriteLine(displayText.Count());
            Console.ReadLine();
        }
    }
}
