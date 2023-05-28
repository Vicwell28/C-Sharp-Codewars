using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class BinaryAddition
	{
		/*
		 Implement a function that adds two numbers together and returns their sum in binary. The conversion can be done before, or after the addition.

		The binary number returned should be a string.

		Examples:(Input1, Input2 --> Output (explanation)))

		1, 1 --> "10" (1 + 1 = 2 in decimal or 10 in binary)
		5, 9 --> "1110" (5 + 9 = 14 in decimal or 1110 in binary)
		 */

		public static string binaryAddition(int num1, int num2)
		{
			int sum = num1 + num2;
			int pow = 0;

			while (Math.Pow(2, pow) <= sum)
				pow++;

			if (Math.Pow(2, pow)  > sum)
				pow--;

			string binary = "";

			for (int i = pow; i >= 0; i--)
			{
				int power = (int)Math.Pow(2, i);
                binary += (power & sum) == power ? "1" : "0";
			}

			return binary;
		}


		public static string AddBinary(int a, int b) => Convert.ToString(a + b, 2);


	}
}
