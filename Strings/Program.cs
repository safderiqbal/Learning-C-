using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
          //  String myString = "Go to your C:\\ drive";
            //String myString = "My \"so called \" life";
           // string myString = "What if I need\n a new line?";

            //string myString = string.Format("{0}!", "Hello");
            //string myString = string.Format("Make: {0} (Model: {1})", "BMW", "745li");

            string myString = string.Format("{0:C}", 123.45);

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
