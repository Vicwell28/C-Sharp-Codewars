using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class SumWithoutHighestLowest
	{
		/*
		Task
		Sum all the numbers of a given array ( cq. list ), except the highest and the lowest element ( by value, not by index! ).

		The highest or lowest element respectively is a single element at each edge, even if there are more than one with the same value.

		Mind the input validation.

		Example
		{ 6, 2, 1, 8, 10 } => 16
		{ 1, 1, 11, 2, 3 } => 6
		Input validation
		If an empty value ( null, None, Nothing etc. ) is given instead of an array, or the given array is an empty list or
		a list with only 1 element, return 0.

		*/

		public static int Sum(int[] numbers) => numbers.Length > 1 ? numbers.Where(it => it != null).Sum() - numbers.Min() - numbers.Max() : 0;
		public static int Sum(int?[] numbers)
		{
			if (numbers == null || numbers.Length < 2)
			{
				return 0;
			}

			int sum = (int)numbers.Where(it => it != null).Sum()!;
			int min = (int)numbers.Where(it => it != null).Min()!;
			int max = (int)numbers.Where(it => it != null).Max()!;

			return sum - min - max;
		}

		//public static int Sum(int[] numbers)
		//{
		//	return numbers == null || numbers.Length < 2
		//		? 0
		//		: numbers.Sum() - numbers.Max() - numbers.Min();
		//}
	}
}
