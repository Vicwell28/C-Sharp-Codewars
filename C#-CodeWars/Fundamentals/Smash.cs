using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	public class Smashh
	{
		public static string Smash(string[] words) => string.Join(" ", words.Select(item => item.Trim()));
		
	}
}
