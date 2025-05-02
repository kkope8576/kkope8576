using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Algorithm.E01.Solution.Classes.Runtime.Solution_02
{
	/**
	 * Solution 2
	 */
	internal class CS01Solution_02
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			var oRandom = new Random();
			var oListValues = new List<int>();

			for(int i = 0; i < 10; ++i)
			{
				oListValues.Add(oRandom.Next(1, 100));
			}

			Console.WriteLine("=====> 리스트 - 정렬 전 <=====");
			S01PrintValues_02(oListValues);

			S01SortValues_02(oListValues, S01Compare_ByAscending_02);

			Console.WriteLine("\n=====> 리스트 - 정렬 후 (오름차순) <=====");
			S01PrintValues_02(oListValues);

			S01SortValues_02(oListValues, S01Compare_ByDescending_02);

			Console.WriteLine("\n=====> 리스트 - 정렬 후 (내림차순) <=====");
			S01PrintValues_02(oListValues);
		}

		/** 오름차순으로 비교한다 */
		private static int S01Compare_ByAscending_02(int a_nLhs, int a_nRhs)
		{
			return a_nLhs - a_nRhs;
		}

		/** 내림차순으로 비교한다 */
		private static int S01Compare_ByDescending_02(int a_nLhs, int a_nRhs)
		{
			return a_nRhs - a_nLhs;
		}

		/** 값을 정렬한다 */
		private static void S01SortQuick_02(List<int> a_oListValues,
			int a_nLeft, int a_nRight, Func<int, int, int> a_oCompare)
		{
			// 정렬이 불가능 할 경우
			if(a_nLeft >= a_nRight)
			{
				return;
			}

			int nMiddle = (a_nLeft + a_nRight) / 2;

			int nIdx_Pivot = (a_oCompare(a_oListValues[a_nLeft], a_oListValues[nMiddle]) >= 0) ? 
				a_nLeft : nMiddle;

			nIdx_Pivot = (a_oCompare(a_oListValues[nIdx_Pivot], a_oListValues[a_nRight]) <= 0) ?
				nIdx_Pivot : a_nRight;

			int nTemp = a_oListValues[a_nLeft];
			a_oListValues[a_nLeft] = a_oListValues[nIdx_Pivot];
			a_oListValues[nIdx_Pivot] = nTemp;

			int nLeft = a_nLeft + 1;
			int nRight = a_nRight;
			int nPivot = a_nLeft;

			while(true)
			{
				while(nLeft < nRight && a_oCompare(a_oListValues[nPivot], a_oListValues[nLeft]) >= 0)
				{
					nLeft += 1;
				}

				while(nLeft <= nRight && a_oCompare(a_oListValues[nPivot], a_oListValues[nRight]) <= 0)
				{
					nRight -= 1;
				}

				// 정렬이 불가능 할 경우
				if(nLeft >= nRight)
				{
					break;
				}

				nTemp = a_oListValues[nLeft];
				a_oListValues[nLeft] = a_oListValues[nRight];
				a_oListValues[nRight] = nTemp;
			}

			// 정렬이 필요 할 경우
			if(a_oCompare(a_oListValues[nPivot], a_oListValues[nRight]) > 0)
			{
				nTemp = a_oListValues[nRight];
				a_oListValues[nRight] = a_oListValues[nPivot];
				a_oListValues[nPivot] = nTemp;
			}

			S01SortQuick_02(a_oListValues, a_nLeft, nRight - 1, a_oCompare);
			S01SortQuick_02(a_oListValues, nRight + 1, a_nRight, a_oCompare);
		}

		/** 값을 정렬한다 */
		private static void S01SortValues_02(List<int> a_oListValues,
			Func<int, int, int> a_oCompare)
		{
			S01SortQuick_02(a_oListValues, 0, a_oListValues.Count - 1, a_oCompare);
		}

		/** 값을 출력한다 */
		private static void S01PrintValues_02(List<int> a_oListValues)
		{
			for(int i = 0; i < a_oListValues.Count; ++i)
			{
				Console.Write("{0}, ", a_oListValues[i]);
			}

			Console.WriteLine();
		}
	}
}
