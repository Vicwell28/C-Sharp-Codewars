using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	internal class NumberOfPeopleInTheBus
	{
		/*
		There is a bus moving in the city which takes and drops some people at each bus stop.

		You are provided with a list (or array) of integer pairs. Elements of each pair represent the number of people 
		that get on the bus (the first item) and the number of people that get off the bus (the second item) at a bus stop.

		Your task is to return the number of people who are still on the bus after the last bus stop (after the last array). 
		Even though it is the last bus stop, the bus might not be empty and some people might still be inside the bus, they are 
		probably sleeping there :D

		Take a look on the test cases.

		Please keep in mind that the test cases ensure that the number of people in the bus is always >= 0. So the returned integer 
		can't be negative.

		The second value in the first pair in the array is 0, since the bus is empty in the first bus stop.
		 */


		public static int Number(List<int[]> peopleListInOut)
		{
			int total = peopleListInOut.Select(item =>
			{
				return item[0];
			}).ToArray().Sum();

			int down = peopleListInOut.Select(item =>
			{
				return item[1];
			}).ToArray().Sum();

			int res = total - down;

			return res;
		}

		    //return peopleListInOut.Sum(Item => Item[0] - Item[1]);

	}
}
