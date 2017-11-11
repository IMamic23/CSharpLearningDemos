using System;

namespace LyndaInterfacesDemo
{
    interface IStorable
    {
        void Save();
        void Load();
        Boolean NeedsSave { get; set; }
    }
}
