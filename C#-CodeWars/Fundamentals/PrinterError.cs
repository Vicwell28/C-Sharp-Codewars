using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	public class Printer
	{
		public static string PrinterError(String s)
		{
			int total = s.Length; 
			int error = s.Where(i => !"abcdefghijklm".ToList().Contains(i)).Count();

			return $"{total}/{error}"; 
		}
	}
}
