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

		public int GetSum(int a, int b)
		{
			int min = Math.Min(a, b);
			int max = Math.Max(a, b);
			return Enumerable.Range(min, max - min + 1).Sum();
		}

		public static string Longest(string s1, string s2)
		{
			var combined = s1 + s2;
			var uniqueChars = new HashSet<char>(combined);
			var sortedChars = uniqueChars.OrderBy(c => c);
			return string.Concat(sortedChars);
		}

		public static int Divisors(int n)
		{
			int num = 0;

			for (int i = 1; i <= n; i++)
			{
				if (n % i == 0) { num++; }
			}

			return num;
		}

		public static int[] DeleteNth(int[] arr, int x)
		{
			arr.Where((num, idx) =>
			{
				if (arr.Skip(idx + 1).Count(it => it == num) > x) return false;

				return true;
			});

			return arr;
		}

		public static int[] minMax(int[] lst)
		{
			var min = lst.Min();
			var max = lst.Max();

			return new[] { min, max };
		}


		public static string HowMuchILoveYou(int nb_petals)
		{
			var phrases = new List<string>()
			{
				"I love you",
				"a little",
				"a lot",
				"passionately",
				"madly",
				"not at all"
			};

			int index = (nb_petals - 1) % phrases.Count;
			return phrases[index];
		}

	}
}