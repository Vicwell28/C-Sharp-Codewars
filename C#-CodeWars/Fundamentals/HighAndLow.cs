using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
    static class HighAndLoww
    {
		public static string HighAndLow(string numbers)
		{
			var numbersTwo = numbers.Split(' ').Select(i => int.Parse(i));
			var min = numbersTwo.Min();
			var max = numbersTwo.Max();
			return $"{max} {min}"; 
		}

	}
}
