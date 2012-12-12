using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Toyota";
            myNewCar.Model = "4Runner";
            myNewCar.Year = 2006;
            myNewCar.OriginalPrice = 35000;
            myNewCar.Colour = "White";

            //Car myOtherCar = myNewCar;

            //Console.WriteLine(myOtherCar.Make);

            //myNewCar = null;
            //myOtherCar = null;

            //Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Colour);

            //determineMarketValue(myNewCar);

            //double myValue = myNewCar.DetermineMarketValue();

            //myNewCar.DetermineMarketValue();
            //Console.WriteLine(myNewCar.CurrentValue.ToString());
            Console.WriteLine("Before: " + myNewCar.Make);
            doByValue(myNewCar);
            Console.WriteLine("After By Value: " + myNewCar.Make);
            doByReference(ref myNewCar);
            Console.WriteLine("After By Reference: " + myNewCar.Make);

            Console.ReadLine();
        }

        //private static double determineMarketValue(Car car)
        //{

        //    return 100.0;
        //}

        private static void doByValue(Car car)
        {
            car = new Car();
            car.Make = "BMW";
        }

        private static void doByReference(ref Car car)
        {
            car = new Car();
            car.Make = "BMW";
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public int OriginalPrice { get; set; }
        public int CurrentValue { get; set; }

        public double DetermineMarketValue()
        {
            double carValue = (((double)DateTime.Now.Year - (double)this.Year) / 10) * this.OriginalPrice;
            this.CurrentValue = (int)carValue;
            return carValue;
        }

    }
}
