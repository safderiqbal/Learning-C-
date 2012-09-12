using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class HelloWorld
    {
        private string first = null;
        private string middle = null;
        private string surname = null;
        private bool hasMiddle = false;

        private bool checkString(string temp)
        {
            try
            {
                bool letter = false;
                bool flag = false;

                foreach (char c in temp)
                {
                    if (char.IsLetter(c))
                        letter = true;
                    else if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
                        flag = true;
                } // foreach temp

                if (flag)
                    throw new System.Exception("No valid input was provided.");
                else if (!letter)
                    throw new System.Exception("No letters were entered.");

                return true;
            } // try
            catch (Exception e)
            {
                Console.Error.WriteLine("Error: " + e);
                return false;
            }
        } // checkString

        private string readString()
        {
            string temp = Console.ReadLine();

            if (checkString(temp))
                return temp.Trim();
            else
            {
                Console.WriteLine("Something was wrong with the input provided. Please try again.");
                return readString();
            } // else
        } // isString

        private int getName(int control)
        {
            if (control < 0 || control > 3)
                return -1;

            TextInfo ti = new CultureInfo("en-US", false).TextInfo;

            switch (control)
            {
                case 1:
                    {
                        Console.WriteLine("Please enter your first name: ");
                        first = ti.ToTitleCase(ti.ToLower(readString()));
                        return 0;
                    } // 1
                case 2:
                    {
                        Console.WriteLine("Please enter your middle name/s: ");
                        middle = ti.ToTitleCase(ti.ToLower(readString()));
                        return 0;
                    } // 2
                case 3:
                    {
                        Console.WriteLine("Please enter your surname: ");
                        surname = ti.ToTitleCase(ti.ToLower(readString()));
                        return 0;
                    } // 3
                default:
                    return -1;
            } // switch
        } // getLine

        private void checkMiddle()
        {
            TextInfo ti = new CultureInfo("en-US", false).TextInfo;
            
            Console.WriteLine("Do you have a middle name? [Y/N]");
            if (String.Compare(ti.ToLower(readString()), "y") == 0)
                hasMiddle = true;
            else
                hasMiddle = false;
        } // checkMiddle

        private bool getFullName()
        {
            try
            {
                checkMiddle();
                getName(1);

                if (hasMiddle)
                {
                    getName(2);
                } // if

                getName(3);

                return true;
            } // try
            catch(Exception e)
            {
                Console.Error.WriteLine(e);
                return false;
            } // catch
        } // getName()

        static void Main(string[] args)
        {
            HelloWorld p = new HelloWorld();
            if (!p.getFullName())
                Environment.Exit(-1);
            else
            {
                String output = p.first + " ";
                if (p.hasMiddle)
                    output += p.middle + " ";
                output += p.surname;

                Console.WriteLine("\nHello " + output + ".\n\nPress any key to exit.");
                Console.ReadKey();
            } // else
        }   
    }
}
