//#define P_S01_SOLUTION_05_01
#define P_S01_SOLUTION_05_02

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_05
{
	/**
	 * Solution 5
	 */
	internal class CS01Solution_05
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			Console.Write("라인 수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nNumLines);

#if P_S01_SOLUTION_05_01
			for(int i = 0; i < nNumLines; ++i)
			{
				for(int j = 0; j <= i; ++j)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = nNumLines - 1; i >= 0; --i)
			{
				for(int j = 0; j <= i; ++j)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = 0; i < nNumLines; ++i)
			{
				for(int j = nNumLines - 1; j > i; --j)
				{
					Console.Write(" ");
				}

				for(int j = 0; j <= i; ++j)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = nNumLines - 1; i >= 0; --i)
			{
				for(int j = nNumLines - 1; j > i; --j)
				{
					Console.Write(" ");
				}

				for(int j = 0; j <= i; ++j)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}
#elif P_S01_SOLUTION_05_02
			for(int i = 0; i < nNumLines; ++i)
			{
				for(int j = 0; j < nNumLines; ++j)
				{
					Console.Write("{0}", (j <= i) ? "*" : " ");
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = nNumLines - 1; i >= 0 ; --i)
			{
				for(int j = 0; j < nNumLines; ++j)
				{
					Console.Write("{0}", (j <= i) ? "*" : " ");
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = 0; i < nNumLines; ++i)
			{
				for(int j = nNumLines - 1; j >= 0; --j)
				{
					Console.Write("{0}", (j <= i) ? "*" : " ");
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = nNumLines - 1; i >= 0; --i)
			{
				for(int j = nNumLines - 1; j >= 0; --j)
				{
					Console.Write("{0}", (j <= i) ? "*" : " ");
				}

				Console.WriteLine();
			}
#endif // #if P_S01_SOLUTION_05_01
		}
	}
}
