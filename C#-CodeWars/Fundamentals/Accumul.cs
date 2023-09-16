using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__CodeWars.Fundamentals
{
	public class Accumul
	{
		public static string Accum(string s)
		{
			return string.Join("-", s.Select((valor, indice) => char.ToUpper(valor) + new string(char.ToLower(valor), indice)));
		}
	}
}
