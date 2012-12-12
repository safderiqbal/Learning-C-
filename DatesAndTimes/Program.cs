using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToShortDateString());
            //Console.WriteLine(myValue.AddHours(-3).ToShortTimeString());

            //Console.WriteLine(myValue.Month.ToString());

            //DateTime myBirthdate = new DateTime(1990, 1, 31);
            DateTime myBirthdate = DateTime.Parse("31/01/1990");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthdate);
            Console.WriteLine(myAge.TotalDays.ToString());

            Console.ReadLine();
        }
    }
}
