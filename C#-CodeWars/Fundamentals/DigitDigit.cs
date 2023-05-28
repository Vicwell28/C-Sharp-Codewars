using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class DigitDigit
	{

		/*
		Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

		For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1. (81-1-1-81)

		Example #2: An input of 765 will/should return 493625 because 72 is 49, 62 is 36, and 52 is 25. (49-36-25)

		Note: The function accepts an integer and returns an integer.

		Happy Coding!
		*/


		public static int digitDigit(int nums)
		{
			return int.Parse(string.Join("", nums.ToString().Select(it => $"{int.Parse(it.ToString()) * int.Parse(it.ToString())}").ToArray()));
		}

		public static int SquareDigits(int n) => int.Parse(string.Join("", n.ToString().Select(it => $"{int.Parse(it.ToString()) * int.Parse(it.ToString())}").ToArray()));

		//return int.Parse(String.Concat(n.ToString().Select(a => (int) Math.Pow(char.GetNumericValue(a), 2))));

	}
}
