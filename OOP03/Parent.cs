using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
     class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Parent constructor called");
        }
        public virtual int Multiply()
        {
            return X * Y;
        }
        public void MyFunc() { 
            Console.WriteLine("Parent class");
        }
        public override string ToString()
        {
            return $"X: {X}\nY: {Y}";
        }
    }
}
