using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	public class OrderKata
	{
		public static string orderKata(string words)
		{
			var splitWords = words.Split(" ");

			return string.Join(" ", splitWords.OrderBy(word =>
			{
				for (int i = 0; i <= 9; i++)
				{
					if (word.Contains(i.ToString()))
						return i;
				}
				return int.MaxValue;
			}));
		}
	}
}
