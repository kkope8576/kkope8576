#define P_PRACTICE_P01_PRACTICE_01_01
#define P_PRACTICE_P01_PRACTICE_01_02
#define P_PRACTICE_P01_PRACTICE_01_03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02020000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_01
{
	/**
	 * Practice 1
	 */
	internal class CP01Practice_01
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if P_PRACTICE_P01_PRACTICE_01_01
			Console.Write("라인 수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nNumLines);

			for(int i = 0; i < nNumLines; ++i)
			{
				for(int j = 0; j <= i; ++j)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}
#elif P_PRACTICE_P01_PRACTICE_01_02
			Console.Write("라인 수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nNumLines);

			for(int i = 0; i < nNumLines; ++i)
			{
				for(int j = 0; j < nNumLines; ++j)
				{
					bool bIsEnableA = i == j;
					bool bIsEnableB = i == (nNumLines - j - 1);

					Console.Write("{0}", (bIsEnableA || bIsEnableB) ? '*' : ' ');
				}

				Console.WriteLine();
			}
#elif P_PRACTICE_P01_PRACTICE_01_03
			Console.Write("라인 수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nNumLines);

			for(int i = 0; i < nNumLines; ++i)
			{
				for(int j = 0; j < nNumLines; ++j)
				{
					Console.Write("{0}", (j <= i) ? '*' : ' ');
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = nNumLines - 1; i >= 0; --i)
			{
				for(int j = 0; j < nNumLines; ++j)
				{
					Console.Write("{0}", (j <= i) ? '*' : ' ');
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = 0; i < nNumLines; ++i)
			{
				for(int j = nNumLines - 1; j >= 0; --j)
				{
					Console.Write("{0}", (j <= i) ? '*' : ' ');
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = nNumLines - 1; i >= 0; --i)
			{
				for(int j = nNumLines - 1; j >= 0; --j)
				{
					Console.Write("{0}", (j <= i) ? '*' : ' ');
				}

				Console.WriteLine();
			}
#endif // #if P_PRACTICE_P01_PRACTICE_01_01
		}
	}
}
