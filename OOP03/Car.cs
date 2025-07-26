using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
     class Car
    {
        //#region Attributes
        //private int id;
        //private string model;
        //private double  speed;
        //#endregion
        #region Automatic Properties
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        #endregion
        #region CLTR
        public Car(int id, string model , double speed)
        {   Id = id;
            Model = model;
            Speed = speed;
            Console.WriteLine("1st constructor");
        }
        //Constructor overloading
        public Car(int _id, string _model): this(_id, _model, 0.0)
        {
           Console.WriteLine("2nd constructor");
        }
        public Car(int _id): this(_id, "Unknown", 0.0)
        {
            Console.WriteLine("3rd constructor");
        }

        #endregion
        #region methods
        public override string ToString()
        {
                return $"Id: {Id}\nModel: {Model}\nSpeed: {Speed} km/h";
        }
        #endregion

    }
}
