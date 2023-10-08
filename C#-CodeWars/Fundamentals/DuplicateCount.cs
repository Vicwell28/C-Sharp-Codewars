using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	public partial class Kata
	{
		public static int DuplicateCount(string str) => str.ToLower().Where(letter => str.Count(it => it == letter) > 1).Distinct().Count();
	}
}
