using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class CountingSheep
	{
		//public static void countingSheep(List<bool> list) 
		//{
		//	list.Where(item => item == true).ToList().Count();
		//}

		public static int countSheeps(bool[] sheeps) => sheeps.Where(item => item == true).Count();


		

		//public static int CountSheeps(bool[] sheeps)
		//{
		//	return sheeps.Count(s => s);
		//}

	}
}
