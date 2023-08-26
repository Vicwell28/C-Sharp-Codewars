using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	public static class JadenCase
	{
		public static string ToJadenCase(this string phrase)
		{
			return string.Join(" ", phrase.Split(' ').Select(x => x.First().ToString().ToUpper() + x.Remove(0, 1)));
		}
	}
}
