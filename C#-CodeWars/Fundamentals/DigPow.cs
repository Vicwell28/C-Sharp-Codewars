using System;
using System.Linq;

namespace C__CodeWars.Fundamentals
{
	public class DigPow
	{
		public static long digPow(int n, int p)
		{
			var digits = n.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();

			double total = digits.Select((digit, index) => Math.Pow(digit, p + index)).Sum();

			double totalDos = 0;
			int k;
			for (k = 1; totalDos < total; k++)
			{
				totalDos += n;
			}

			return totalDos == total ? k - 1 : -1;
		}
	}
}
