using Common;
namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UserDefinedType [Class]
            //Car c1;
            //c1 = new Car(1, "Toyota", 180.5);
            //Console.WriteLine(c1);
            //Car c2 = new Car(2, "Honda");
            //Console.WriteLine(c2);
            //Car c3 = new Car(3);
            //Console.WriteLine(c3);
            #endregion
            #region Inheritance
            //Parent p1 = new Parent(10, 20);
            //p1.X = 100;
            //p1.Y = 200;
            //Console.WriteLine(p1);
            //Console.WriteLine($"Multiply: {p1.Multiply()}");
            //p1.MyFunc();

            //Child child = new Child(10, 20, 30);
            //child.X = 100;
            //child.Y = 200;
            //child.Z = 300;
            //Console.WriteLine(child);
            //Console.WriteLine($"Multiply: {child.Multiply()}");
            //child.MyFunc();
            #endregion
            #region AccessModifiers
            //TypeA typeA = new TypeA();
            //typeA.A = 10; // Error: A is private in TypeA
            //typeA.B = 20; // OK: B is internal in TypeA
            //typeA.C = 30; // OK: C is public in TypeA
            //typeA.X = 40; // Error: X is private protected in TypeA
            //typeA.Y = 50; // Error: Y is protected in TypeA
            //typeA.Z = 60; // Error: Z is protected internal in TypeA

            #endregion
        }
    }
}
