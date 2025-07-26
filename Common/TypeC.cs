using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeC
    {
        TypeB typeB= new TypeB();
        public TypeC()
        {
            //typeB.A = 10; // Error: A is private in TypeA
            typeB.B = 20; // OK: B is internal in TypeA
            typeB.C = 30; // OK: C is public in TypeA
            //typeB.X = 40; // Error: X is private protected in TypeA
            //typeB.Y = 50; // Error: Y is protected in TypeA
            //typeB.Z = 60; // Error: Z is protected internal in TypeA
        }
    }
}
