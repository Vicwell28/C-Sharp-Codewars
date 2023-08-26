using System;

namespace C__CodeWars.Fundamentals
{
	public static class PileOfCubes
	{
		public static long findNb(long m)
		{
			long idx = 0;
			long total = 0;

			while (total < m)
			{
				idx++;
				total += (long)Math.Pow(idx, 3);
			}

			return total == m ? idx : -1;
		}
	}
}
