using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class DescendingOrder
	{

		/*
		 Your task is to make a function that can take any non-negative integer as an argument and return it with its digits in 
		descending order. Essentially, rearrange the digits to create the highest possible number.

		Examples:
		Input: 42145 Output: 54421

		Input: 145263 Output: 654321

		Input: 123456789 Output: 987654321
		 */
		public static int descendingOrder(int num)
		{
			int[] nums = num.ToString().Select(x => int.Parse(x.ToString())).ToArray();

			Array.Sort(nums, (x, y) => y.CompareTo(x));

			return int.Parse(string.Join(string.Empty, nums.Select(it => it.ToString()).ToArray()));
		}

		//public static int DescendingOrder(int num)
		//{
		//	char[] digits = num.ToString().ToCharArray();
		//	Array.Sort(digits);
		//	Array.Reverse(digits);
		//	return int.Parse(new string(digits));
		//}

		//public static int DescendingOrder(int num)
		//{
		//	return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));
		//}


	}
}
