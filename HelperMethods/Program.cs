using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(superSecretFormula("Bob"));

            Console.WriteLine(superSecretFormula());

            Console.ReadLine();
        }

        private static string superSecretFormula()
        {
            return "Hello World";
        }


        private static string superSecretFormula(string name)
        {
            return string.Format("Hello World, {0}",name);
        }
    }
}
