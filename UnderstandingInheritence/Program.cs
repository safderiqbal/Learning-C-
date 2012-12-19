using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Colour = "Black";
            myCar.Year = 2005;

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 2006;
            myTruck.Colour = "Black";
            myTruck.TowingCapacity = 1200;

            someMethod(myCar);
            someMethod(myTruck);
            //myCar.PrintMe();

            Console.ReadLine();
        }

        private static void someMethod(Car car)
        {
            Console.WriteLine("From someMethod: {0}", car.Make);
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public void PrintMe()
        {
            Console.WriteLine("{0} - {1}", this.Make, this.Model);
        }
    }

    class Truck : Car
    {
        public int TowingCapacity { get; set; }

    }
}
