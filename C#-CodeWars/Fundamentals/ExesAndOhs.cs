using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class ExesAndOhs
	{

		/*
		Check to see if a string has the same amount of 'x's and 'o's. The method must return a boolean and be case insensitive. 
		The string can contain any char.

		Examples input/output:

		XO("ooxx") => true
		XO("xooxx") => false
		XO("ooxXm") => true
		XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
		XO("zzoo") => false
		 */

		static public bool XO(string input) => input.ToLower().Count(item => item == 'x') == input.ToLower().Count(item => item == 'o');
		
	}
}
