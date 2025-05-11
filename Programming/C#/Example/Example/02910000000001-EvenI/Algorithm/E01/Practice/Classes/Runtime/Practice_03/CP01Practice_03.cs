using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Algorithm.E01.Practice.Classes.Runtime.Practice_03
{
	internal class CP01Practice_03
	{
		public static void Start(string[] args)
		{
			Console.Write("문자열 입력 : ");
			string Str = Console.ReadLine();

			Console.Write("패턴 입력 : ");
			string Pattern = Console.ReadLine();

			Console.WriteLine("\n결과 : {0}",(Str, Pattern));
		}

		private static int[] Make_BadCharacter(string oPattern)
		{
			var oTable_BadCharacter = new int[sbyte.MaxValue + 1];

			for (int i = 0; i < oTable_BadCharacter.Length; i++)
			{
				oTable_BadCharacter[i] = -1;
			}

			for (int i = 0; i < oPattern.Length; i++)
			{
				oTable_BadCharacter[oPattern[i]] = i;
			}

			return oTable_BadCharacter;
		}

		private static int[] Make_GoodCharacter(string oPattern)
		{
			int i = oPattern.Length + 1;
			int j = i + 1;

			var oTable_GoodCharacter = new int[oPattern.Length + 1];
			oTable_GoodCharacter[i] = j;

			while ( i > 0 )
			{
				if (oPattern[i-1] == oPattern[j-1])
				{
					i--;
					j--;
					oTable_GoodCharacter[i] = j;
				}
				else
				{
					oTable_GoodCharacter[i] = j - i;
					j = oTable_GoodCharacter[j];
				}
			}

			return oTable_GoodCharacter;
		}
	}
}
