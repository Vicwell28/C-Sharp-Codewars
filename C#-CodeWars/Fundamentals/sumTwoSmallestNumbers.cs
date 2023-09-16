using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	public class SumTwoSmallestNumbers
	{
		public static int sumTwoSmallestNumbers(int[] numbers)
		{
			return numbers.OrderBy(x => x).Take(2).Sum();
		}
	}
}
