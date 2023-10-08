using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	public class KataKata
	{
		public static int[] ArrayDiff(int[] a, int[] b)
		{
			var setB = new HashSet<int>(b);
			return a.Where(num => !setB.Contains(num)).ToArray();
		}

		public static bool IsPangram(string str)
		{
			var hashSet = new HashSet<char>();

			foreach (char c in str.ToLower())
				if (char.IsLetter(c))
					hashSet.Add(c);

			return hashSet.Count == 26;
		}

		public static string ToAlternatingCase(string s)
		{
			var result = new StringBuilder(s.Length);

			foreach (char c in s)
			{
				char newChar = char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c);
				result.Append(newChar);
			}

			return result.ToString();
		}

		public static string NoSpace(string input) => input.Replace(" ", string.Empty);

		public static int CountSmileys(string[] smileys)
		{
			var eyes = new char[] { ':', ';' };
			var noses = new char[] { '-', '~',};
			var mouths = new char[] { ')', 'D' };

			return smileys.Count(face =>
				face.Length >= 2 &&
				face.Length <= 3 &&
				eyes.Contains(face[0]) &&
				mouths.Contains(face.Last()) &&
				(face.Length == 2 || noses.Contains(face[1]))
			);
		}

	}
}