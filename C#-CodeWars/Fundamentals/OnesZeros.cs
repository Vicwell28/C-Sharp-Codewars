using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class OnesZeros
	{
		public static int onesZeros(int[] bin)
		{
			int lenghtBin = bin.Length;

			return bin.Select((it, idx) =>
			{
				if (it != 0)
					it = (int)Math.Pow(2, lenghtBin - idx - 1);

				return it;
			}).ToArray().Sum();
		}

		public static int binaryArrayToNumber(int[] BinaryArray)
		{
			int lenghtBin = BinaryArray.Length;

			return BinaryArray.Select((it, idx) =>
			{
				if (it != 0)
					it = (int)Math.Pow(2, lenghtBin - idx - 1);

				return it;
			}).ToArray().Sum();
		}

		//public static int binaryArrayToNumber(int[] BinaryArray)
		//{
		//	return Convert.ToInt32(string.Join("", BinaryArray), 2);
		//}
	}
}
