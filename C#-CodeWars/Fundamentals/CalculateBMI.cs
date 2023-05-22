using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C__CodeWars.Fundamentals
{
	internal class CalculateBMI
	{

		/*
		
		Write function bmi that calculates body mass index (bmi = weight / height2).

		if bmi <= 18.5 return "Underweight"

		if bmi <= 25.0 return "Normal"

		if bmi <= 30.0 return "Overweight"

		if bmi > 30 return "Obese"

		 */

		public static string Bmi(double weight, double height)
		{
			double bmi = weight / (height * height);

			return bmi > 30 ? "Obese" : bmi > 25 ? "Overweight" : bmi > 18.5 ? "Normal" : "Underweight";
		}
	}
}
