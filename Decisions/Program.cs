using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Decisions
{
	class Program
	{
		static void Main(string[] args)
		{
			play();
		}

		private static void play()
		{
			Console.WriteLine("Would you prefer what is behind door number 1, 2, or 3?");
			int min = 1;
			int max = 4;

			// Load the random numbers
			ArrayList availableNumbers = new ArrayList();
			for (int i = min; i < max; i++)
				availableNumbers.Add(i);

			// Assign the first number to the car's door number
			int carValue = RandomNumber(min, max);
			availableNumbers.Remove(carValue);
			int boatValue = carValue;
			int catValue;
			string message;

			// Randomly search for a value for the boat's door number
			while (!availableNumbers.Contains(boatValue))
				boatValue = RandomNumber(min, max);
			availableNumbers.Remove(boatValue);

			// Assign the cat value the remaining number
			catValue = (int)availableNumbers[0];

            // DEBUG
            //Console.WriteLine(String.Format("CarValue: {0} BoatValue: {1} CatValue: {2}",carValue,boatValue,catValue));

			// Read the user input
            int userValue = readNumber(min, max);

            // The 'CatValue' variable now only holds debug purposes, due to sufficient validation on the integer input
			if (userValue == carValue)
				message = "You won a new car!";
			else if (userValue == boatValue)
				message = "You won a new boat!";
			else
				message = "You won a new cat!";

			Console.WriteLine(message);

			Console.WriteLine("Do you want to play again? [Y/N]");
			TextInfo ti = new CultureInfo("en-US", false).TextInfo;
			if (String.Compare(ti.ToLower(readString()), "y") == 0)
			{
				// Repeat
				Console.WriteLine("");
				play();
			}
			else
				// Cleanly exit
				Environment.Exit(-1);
		}

	// Helper Methods

		private static int RandomNumber(int min, int max)
		{
            Random random = new Random((int)DateTime.Now.TimeOfDay.TotalMilliseconds);
			return random.Next(min, max);
		}

		private static int readNumber(int min, int max)
		{
            String obj =  Console.ReadLine();
            int value;
            if (int.TryParse(obj, out value) && value < max++ && value > min--)
                return value;
            else
            {
                Console.WriteLine("Something was wrong with the input provided. Please try again.");
                return readNumber(min, max);
            }
		}

		private static string readString()
		{
			string temp = Console.ReadLine();

			if (checkString(temp))
				return temp.Trim();
			else
			{
				Console.WriteLine("Something was wrong with the input provided. Please try again.");
				return readString();
			}
		}

		private static bool checkString(string temp)
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
				}

				if (flag)
					throw new System.Exception("No valid input was provided.");
				else if (!letter)
					throw new System.Exception("No letters were entered.");

				return true;
			}
			catch (Exception e)
			{
				Console.Error.WriteLine("Error: " + e);
				return false;
			}
		}
	}
}
