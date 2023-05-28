using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class ReverseWords
	{

		/*
		 Complete the function that accepts a string parameter, and reverses each word in the string. All spaces in the string should be retained.

		Examples
		"This is an example!" ==> "sihT si na !elpmaxe"
		"double  spaces"      ==> "elbuod  secaps"
		 */

		public static string reverseWords(string str) => string.Join(" ", str.Split(' ').Select(x => string.Join("", x.Reverse())).ToArray());

		//public static string ReverseWords(string str) => string.Join(" ", str.Split().Select(x => string.Concat(x.Reverse())));



	}
}
