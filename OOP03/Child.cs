using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
     class Child: Parent
    {
        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
            Console.WriteLine("Child constructor called");
        }
        public override string ToString()
        {
            return $"X : {X}\nY: {Y}\nZ: {Z}";
        }
        public override int Multiply()
        {
            return base.Multiply()*Z;
        }
        //new => create new version of the method               
        public new void MyFunc()
        {
            Console.WriteLine("Child class");
        }
    }
}
