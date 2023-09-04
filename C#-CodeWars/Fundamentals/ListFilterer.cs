using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class ListFilterer
	{
		public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems) => listOfItems.OfType<int>();
	}
}
