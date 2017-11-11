﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Television : IElectronicDevice
    {
        public int Volume { get; set; }

        public void On()
        {
            Console.WriteLine("The TV is On");
        }

        public void Off()
        {
            Console.WriteLine("The TV is Off");
        }

        public void VolumeUp()
        {
            if (Volume != 0) Volume--;
                Console.WriteLine($"The TV volume is at {Volume}");
        }

        public void VolumeDown()
        {
            if (Volume != 100) Volume++;
                Console.WriteLine($"The TV volume is at {Volume}");
        }
    }
}
