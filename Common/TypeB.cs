using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB: TypeA
    {
        public TypeB() {
            //A = 10; // Error: A is private in TypeA
            B = 20; // OK: B is internal in TypeA
            C = 30; // OK: C is public in TypeA
            X = 40; // OK: X is private protected in TypeA
            Y = 50; // OK: Y is protected in TypeA
            Z = 60; // OK: Z is protected internal in TypeA
        }
    }
}
