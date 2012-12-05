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

            //string myString = string.Format("{0:C}", 123.45);

            //string myString = string.Format("{0:N}",1234567890);

            //string myString = string.Format("{0:P}", 0.123);

            //string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890);

            string myString = "";

            for (int i = 0; i < 100; i++)
            {
               // myString = myString + "--" + i.ToString();
                myString += "--" + i.ToString();
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
