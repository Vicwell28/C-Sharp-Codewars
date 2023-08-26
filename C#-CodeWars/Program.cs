using C__CodeWars.Fundamentals;
using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;


namespace C__CodeWars
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			//string myString = string.Concat("World".ToArray().Reverse().ToArray());
			//Console.WriteLine(myString);
			//Console.WriteLine(AreYouPlayingBanjo("Victor"));


			////find the needle in the haystack

			//Console.WriteLine(FindNeedle(new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false }));

			//FindNeedleFilter(new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false });
			//FindNeedleMap(new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false });


			//Console.WriteLine(Remove_char("eloquent"));

			//Console.WriteLine(FindAverage(new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 }));

			//Console.WriteLine(CalculateBMI.Bmi(80, 1.80));
			//Console.WriteLine(CalculateBMI.Bmi(100, 1.80));
			//Console.WriteLine(CalculateBMI.Bmi(200, 1.80));
			//Console.WriteLine(CalculateBMI.Bmi(40, 1.80));



			//int[] numeros = ReversedSequence.ReverseSeq(5);

			// Obtener un enumerador utilizando la interfaz IEnumerable
			//IEnumerable enumerable = numeros;
			//IEnumerator enumerator = enumerable.GetEnumerator();

			//// Iterar sobre los elementos utilizando el enumerador
			//while (enumerator.MoveNext())
			//{
			//	int elemento = (int)enumerator.Current;
			//	Console.WriteLine(elemento);
			//}

			//Console.WriteLine(DoubleChar.doubleChar("Vic"));



			//Console.WriteLine(ConvertAStringToAnArray.convertAStringToAnArray("Hola hoal hOla hoLa"));


			//Array.ForEach(ConvertAStringToAnArray.convertAStringToAnArray("Hola hoal hOla hoLa"), Console.WriteLine);


			//Console.WriteLine(NumberOfPeopleInTheBus.Number(new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } }));


			//Console.WriteLine(ReverseWords.reverseWords("Hello word"));

			//Console.WriteLine(SumArrays.sumArrays(new double[] { 1, 5.2, 4, 0, -1 }));


			//Console.WriteLine(BinaryAddition.AddBinary(10, 10));

			//Console.WriteLine(BinaryAddition.AddBinary(1, 1));

			//Console.WriteLine(BinaryAddition.AddBinary(5, 9));

			//Console.WriteLine(BinaryAddition.AddBinary(10, 1));

			//OnesZeros.onesZeros(new int[] {1, 0, 0, 1});

			//CenturyFromYear.СenturyFromYear(1705);
			Console.WriteLine("QRTYPOASDFGHKLZXCVBNM");
			Console.WriteLine(Persist.Persistence(39));
			Console.WriteLine(Persist.Persistence(4));
		}


		//Are You Playing Banjo?

		public static string AreYouPlayingBanjo(string name)
		{
			return name += (name.ToLower())[0] == 'r' ? " plays banjo" : " does not play banjo";
		}


		/*
		Can you find the needle in the haystack?

		Write a function findNeedle() that takes an array full of junk but containing one "needle"

		After your function finds the needle it should return a message (as a string) that says:

		"found the needle at position " plus the index it found the needle, so:

		Example(Input --> Output)

		["hay", "junk", "hay", "hay", "moreJunk", "needle", "randomJunk"] --> "found the needle at position 5" 
		Note: In COBOL, it should return "found the needle at position 6"
		 */

		public static string FindNeedle(object[] haystack)
		{
			for (int i = 0; i < haystack.Length; i++)
			{
				if (haystack[i] is string && haystack[i] == "needle")
				{
					return $"found the needle at position {i}";
				}
			}

			return "Not Found";
		}

		/*
		
		Es correcto, en C# no existe un método específico llamado filter o map para manipular arreglos de objetos directamente como en algunos lenguajes de programación como JavaScript. Sin embargo, en C# puedes lograr funcionalidades similares utilizando otras técnicas y métodos disponibles en el lenguaje.

		Para emular el comportamiento de filter y map en C#, puedes utilizar métodos de extensión de LINQ (Language Integrated Query) junto con expresiones lambda. Aquí tienes ejemplos de cómo puedes realizar estas operaciones:

		 */

		/*
		 Filtrar elementos con LINQ:
		Puedes utilizar el método Where de LINQ para filtrar los elementos de un arreglo en base a una condición. Por ejemplo, para filtrar los elementos del arreglo haystack_1 que son cadenas de caracteres, puedes hacer lo siguiente:
		 */


		public static void FindNeedleFilter(object[] haystack)
		{
			var filteredItems = haystack.Where(item => item is string).ToArray();

			string itemsAsString = string.Join(",", filteredItems);
			Console.WriteLine(itemsAsString);

		}

		/*
			Mapear elementos con LINQ:
			Puedes utilizar el método Select de LINQ para transformar los elementos de un arreglo aplicando una función a cada uno de ellos. Por ejemplo, para convertir todos los elementos del arreglo haystack_1 a minúsculas, puedes hacer lo siguiente:
		 */
		public static void FindNeedleMap(object[] haystack)
		{
			var filteredItems = haystack.Where(item => item != null).ToArray();

			//filteredItems = filteredItems.Select(item => item.ToString().ToLower()).ToArray();

			//var algo = filteredItems.Select((item, index) =>
			//{
			//	var it = item.ToString() + index.ToString();

			//	return it;
			//});

			//string itemsAsString = string.Join(",", algo);

			//Console.WriteLine(itemsAsString);
		}

		public static string Remove_char(string s)
		{
			string str = "";

			for (int i = 0; i < s.Length; i++)
			{

				if (i == 0)
				{
					continue;
				}

				if (i == s.Length - 1)
				{
					continue;
				}


				str += s[i];
			}


			return str;

			//return s.Substring(1, (s.Length - 2));
			//return s.Remove(s.Length - 1, 1).Remove(0, 1);


		}

		/*
		 Write a function which calculates the average of the numbers in a given list.

		Note: Empty arrays should return 0.
		 */

		public static double FindAverage(double[] array)
		{
			if (array.Length == 0)
			{
				return 0;
			}

			double total = 0;

			for (int i = 0; i < array.Length; i++)
			{
				total += array[i];
			}

			total = total / array.Length;

			return total;
			//return array.Length == 0 ? 0 : array.Average();
		}

		//Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.

		public static string boolToWord(bool word)
		{
			return word ? "Yes" : "No";
		}

		/*
		 Deoxyribonucleic acid, DNA is the primary information storage molecule in biological systems. It is composed of four nucleic acid bases Guanine ('G'), Cytosine ('C'), Adenine ('A'), and Thymine ('T').

Ribonucleic acid, RNA, is the primary messenger molecule in cells. RNA differs slightly from DNA its chemical structure and contains no Thymine. In RNA Thymine is replaced by another nucleic acid Uracil ('U').

Create a function which translates a given DNA string into RNA.

For example:

"GCAT"  =>  "GCAU"
The input string can be of arbitrary length - in particular, it may be empty. All input is guaranteed to be valid, i.e. each input string will only ever consist of 'G', 'C', 'A' and/or 'T'.
		 */

		public string dnaToRna(string dna)
		{
			return dna.Replace('T', 'U');
		}
	}
}
