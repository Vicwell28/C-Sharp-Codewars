using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	public class Persist
	{
		public static int Persistence(long n)
		{
			long total = n;
			long div = 1; 
			long idx = 0;
			long digit = long.Parse(total.ToString().Substring(0, 1));

			while (total > 0 && total > 9)
			{
				if (digit * div < total && div < 9)
				{
					div++;
				}
				else
				{
					idx++;
					total = digit * div;
					div = 1; 
					digit = long.Parse(total.ToString().Substring(0, 1));
				}
			}

			return (int)idx; 
		}
	}
}
