#define P_PRACTICE_P01_PRACTICE_03_01
#define P_PRACTICE_P01_PRACTICE_03_02
#define P_PRACTICE_P01_PRACTICE_03_03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02020000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_03
{
	/**
	 * Practice 3
	 */
	internal class CP01Practice_03
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if P_PRACTICE_P01_PRACTICE_03_01
			var oListValues = new List<int>();
			P01SetupValues_03(oListValues);

			Console.WriteLine("=====> 정렬 전 <=====");
			P01PrintValues_03(oListValues);

			P01SortValues_03(oListValues);

			Console.WriteLine("\n=====> 정렬 후 <=====");
			P01PrintValues_03(oListValues);
#elif P_PRACTICE_P01_PRACTICE_03_02

#elif P_PRACTICE_P01_PRACTICE_03_03

#endif // #if P_PRACTICE_P01_PRACTICE_03_01
		}

#if P_PRACTICE_P01_PRACTICE_03_01
		/** 값을 설정한다 */
		private static void P01SetupValues_03(List<int> a_oListValues)
		{
			var oRandom = new Random();

			for(int i = 0; i < 10; ++i)
			{
				a_oListValues.Add(oRandom.Next(1, 100));
			}
		}

		/** 값을 정렬한다 */
		private static void P01SortValues_03(List<int> a_oListValues)
		{
			for(int i = a_oListValues.Count - 1; i > 0; --i)
			{
				for(int j = 0; j < i; ++j)
				{
					// 정렬이 필요 없을 경우
					if(a_oListValues[j] < a_oListValues[j + 1])
					{
						continue;
					}

					int nTemp = a_oListValues[j];
					a_oListValues[j] = a_oListValues[j + 1];
					a_oListValues[j + 1] = nTemp;
				}
			}
		}

		/** 값을 출력한다 */
		private static void P01PrintValues_03(List<int> a_oListValues)
		{
			for(int i = 0; i < a_oListValues.Count; ++i)
			{
				Console.Write("{0}, ", a_oListValues[i]);
			}

			Console.WriteLine();
		}
#elif P_PRACTICE_P01_PRACTICE_03_02

#elif P_PRACTICE_P01_PRACTICE_03_03

#endif // #if P_PRACTICE_P01_PRACTICE_03_01
	}
}
