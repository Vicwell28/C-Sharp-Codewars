using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class DoubleChar
	{
		/*
			Given a string, you have to return a string in which each character (case-sensitive) is repeated once.

			Examples (Input -> Output):
			* "String"      -> "SSttrriinngg"
			* "Hello World" -> "HHeelllloo  WWoorrlldd"
			* "1234!_ "     -> "11223344!!__  "
			Good Luck!
		 */

		public static string doubleChar(string s) {

			string res = string.Join("", s.Select(x => $"{x}{x}"));

			Console.WriteLine(res);


            return ""; 
		}
	}
}
