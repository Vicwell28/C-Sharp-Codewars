using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	public class codewars
	{
		public static bool IsIsogram(string str)
		{
			HashSet<char> seenChars = new HashSet<char>();

			foreach (char c in str.ToLower())
			{
				if (seenChars.Contains(c))
					return false;

				seenChars.Add(c);
			}

			return true;
		}

		public static int[] CountBy(int x, int n) => Enumerable.Range(1, n).Select(i => i * x).ToArray();

		public static long[] SumDigPow(long a, long b)
		{
			return Enumerable
						.Range(0, (int)(b - a + 1))
						.Select(offset => a + offset)
						.Where(number =>
							number.ToString()
							.Select((value, index) => new { value = int.Parse(value.ToString()), index })
							.Aggregate(0.0, (acc, pair) => acc + Math.Pow(pair.value, pair.index + 1)) == number)
						.Select(number => (long)number)
						.ToArray();

		}

		public static long[] SumDigPow(long a, long b)
		{
			var result = new List<long>();

			for (long number = a; number <= b; number++)
			{
				long sum = 0;
				string numberStr = number.ToString();

				for (int i = 0; i < numberStr.Length; i++)
				{
					long digit = long.Parse(numberStr[i].ToString());
					sum += (long)Math.Pow(digit, i + 1);
				}

				if (sum == number)
				{
					result.Add(number);
				}
			}

			return result.ToArray();
		}

		public static long[] SumDigPow(long a, long b)
		{
			var result = new List<long>();

			for (long number = a; number <= b; number++)
			{
				long sumOfPowers = 0;
				var digits = number.ToString();

				for (int i = 0; i < digits.Length; i++)
					sumOfPowers += (long)Math.Pow(char.GetNumericValue(digits[i]), i + 1);
				

				if (sumOfPowers == number)
					result.Add(number);
			}

			return result.ToArray();
		}

		public static int SaleHotDogs(int n) => n * (n < 5 ? 100 : n < 10 ? 95 : 90);


	}
}

Completed in 753.1140ms

Completed in 1033.2990ms

