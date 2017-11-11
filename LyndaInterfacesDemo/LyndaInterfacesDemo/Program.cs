using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace LyndaInterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document");

            d.PropertyChanged += delegate(object sender, PropertyChangedEventArgs e)
            {
                Console.WriteLine($"Doc prop changed: {e.PropertyName}");
            };

            d.NeedsSave = true;

            d.Encrypt();

            if (d is IStorable && d.NeedsSave)
                d.Save();

            d.Decrypt();
            d.Load();

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
