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
			int max = 3;

			// Load the random numbers
			ArrayList availableNumbers = new ArrayList();
			for (int i = min; i <= max; i++)
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

			// Read the user input
				// currently assumes it's a number
			int userValue = Convert.ToInt32(Console.ReadLine());

			if (userValue == carValue)
				message = "You won a new car!";
			else if (userValue == boatValue)
				message = "You won a new boat!";
			else if (userValue == catValue)
				message = "You won a new cat!";
			else
				message = "Sorry, you lose!";

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
			Random random = new Random();
			return random.Next(min, max);
		}

		private static int readNumber()
		{
			return 1;
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
