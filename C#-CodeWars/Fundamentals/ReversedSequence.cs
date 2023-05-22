using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class ReversedSequence
	{
		/*
		Build a function that returns an array of integers from n to 1 where n > 0.

		Example : n=5 --> [5,4,3,2,1]
		 */

		public static int[] ReverseSeq(int n)
		{
			int[] result = new int[n];

			for (int i = 1; i <= n; i++)
			{
				result[i - 1] = i;
			}

			result = result.Reverse().ToArray();

			return result;

			//return Enumerable.Range(1, n).Reverse().ToArray();
		}
	}
}
