using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByRefByVal
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            Console.WriteLine("Before: {0}", i);
            doByValue(i);
            Console.WriteLine("After By Value: {0}", i);
            doByReference(ref i);
            Console.WriteLine("After By Reference: {0}", i);

            Console.ReadLine();
        }

        private static void doByValue(int i)
        {
            i += 1;
        }

        private static void doByReference(ref int i)
        {
            i += 1;
        }

    }
}

