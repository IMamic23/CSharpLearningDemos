﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAndEnumeratorDemo
{
    class Box
    {
        // OPERATOR OVERLOADING

        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        public Box()
            : this(1, 1, 1) { }

        public Box(double l, double w, double b)
        {
            Length = l;
            Width = w;
            Breadth = b;
        }

        public static Box operator +(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth
            };
            return newBox;
        }

        public static Box operator -(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };
            return newBox;
        }

        public static bool operator ==(Box box1, Box box2)
        {
            return (box1.Length == box2.Length) &&
                   (box1.Width == box2.Width) &&
                   (box1.Breadth == box2.Breadth);
        }

        public static bool operator !=(Box box1, Box box2)
        {
            return (box1.Length != box2.Length) ||
                   (box1.Width != box2.Width) ||
                   (box1.Breadth != box2.Breadth);
        }

        public override string ToString()
        {
            return String.Format($"Box with Height: {Length}, Width: {Width}, Breadth: {Breadth}");
        }

        public static explicit operator int(Box b)
        {
            return (int)(b.Length + b.Width + b.Breadth) / 3;
        }

        public static implicit operator Box(int i)
        {
            return new Box(i, i, i);
        }
    }
}
