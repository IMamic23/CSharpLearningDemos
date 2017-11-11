using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Basic.Course.UsingStrings
{
    static class Program
    {
        static void Main(string[] args)
        {
            string userName = "Tom";
            string greeting = "Hello there ";
            Console.WriteLine(greeting + userName);
            Console.ReadLine();

            decimal length1 = 3423.08394m;
            decimal length2 = 324343.24354m;
            string totalLength = (length1 + length2).ToString();
            Console.WriteLine(totalLength);
            Console.ReadLine();

            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "mspaint.exe";
            myProcess.StartInfo.Arguments = "\"c:\\program files\\img4.jpg\"";
            myProcess.Start();
        }
    }
}
