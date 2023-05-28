using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class StringEndsWith
	{
		public static void stringEndsWith(string sen, string end) => sen.EndsWith(end);

		public static bool Solution(string str, string ending) => str.EndsWith(ending);

	}
}
