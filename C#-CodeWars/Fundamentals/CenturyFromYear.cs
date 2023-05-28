using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class CenturyFromYear
	{
		/*
		Introduction
		The first century spans from the year 1 up to and including the year 100, the second century - from the year 101 up
		to and including the year 200, etc.

		Task
		Given a year, return the century it is in.

		Examples
		1705 --> 18
		1900 --> 19
		1601 --> 17
		2000 --> 20
		Note: this kata uses strict construction as shown in the description and the examples, you can read more about it here
		*/

		public static int СenturyFromYear(int year)
		{
			Console.WriteLine((year / 100));

			Console.WriteLine(year % 100 > 0 ? 1 : 0);

			Console.WriteLine((year / 100) + (year % 100 > 0 ? 1 : 0));

			return (year / 100) + (year % 100 > 0 ? 1 : 0); 
		}

		//public static int СenturyFromYear(int year) => (year - 1) / 100 + 1;


	}
}
