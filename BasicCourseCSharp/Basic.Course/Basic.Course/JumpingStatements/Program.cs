using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.JumpingStatements
{
    static class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5] { "Sam", "Tony", "Joy", "Joe", "Sandra" };
            
            foreach (string name in names)
            {
                if (name == "Joy")
                {
                    throw new ApplicationException();
                }
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
