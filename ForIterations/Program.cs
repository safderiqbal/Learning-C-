using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForIterations
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++)
			{
				//Console.WriteLine(i.ToString());
				if (i == 7)
				{
					Console.WriteLine("Found seven!");
					break;
				}
			}

			for (int myX = 0; myX < 10; myX++)
			{
				Console.WriteLine(myX);	
			}

			Console.ReadKey();
		}
	}
}
