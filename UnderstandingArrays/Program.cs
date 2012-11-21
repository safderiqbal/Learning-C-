using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			//int[] numbers = new int[5];
			//numbers[0] = 4;
			//numbers[1] = 8;
			//numbers[2] = 15;
			//numbers[3] = 16;
			//numbers[4] = 23;
			//numbers[5] = 42;


			int[] numbers = { 4, 8, 15, 16, 23 };

			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine(numbers[i]);
			}

			//Console.WriteLine(numbers[1]);
			Console.ReadKey();
		}
	}
}
