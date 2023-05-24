using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class ConvertAStringToAnArray
	{

		/*
		 Write a function to split a string and convert it into an array of words.

		Examples (Input ==> Output):
		"Robin Singh" ==> ["Robin", "Singh"]

		"I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
		 */

		static public string[] convertAStringToAnArray(string s) => s.Split(' ');
	}
}
