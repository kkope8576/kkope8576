using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Algorithm.E01.Solution.Classes.Runtime.Solution_01
{
	/**
	 * Solution 1
	 */
	internal class CS01Solution_01
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

			S01SortValues_01(oListValues);

			Console.WriteLine("=====> 리스트 <=====");
			S01PrintValues_01(oListValues);

			Console.Write("\n정수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nVal);

			int nResult = S01FindVal_01(oListValues, nVal);
			Console.WriteLine("결과 : {0}", nResult);
		}

		/** 값을 탐색한다 */
		private static int S01FindVal_01(List<int> a_oListValues, int a_nVal)
		{
			return S01FindVal_Internal_01(a_oListValues, 
				a_nVal, 0, a_oListValues.Count - 1);
		}

		/** 값을 탐색한다 */
		private static int S01FindVal_Internal_01(List<int> a_oListValues,
			int a_nVal, int a_nLeft, int a_nRight)
		{
			// 값 탐색이 불가능 할 경우
			if(a_nLeft > a_nRight)
			{
				return -1;
			}

			int nMiddle = (a_nLeft + a_nRight) / 2;

			// 값이 존재 할 경우
			if(a_nVal == a_oListValues[nMiddle])
			{
				return nMiddle;
			}

			return (a_nVal < a_oListValues[nMiddle]) ?
				S01FindVal_Internal_01(a_oListValues, a_nVal, a_nLeft, nMiddle - 1) : S01FindVal_Internal_01(a_oListValues, a_nVal, nMiddle + 1, a_nRight);
		}

		/** 값을 정렬한다 */
		private static void S01SortValues_01(List<int> a_oListValues)
		{
			for(int i = 0; i < a_oListValues.Count - 1; ++i)
			{
				for(int j = 0; j < a_oListValues.Count - (i + 1); ++j)
				{
					// 정렬이 필요없을 경우
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
		private static void S01PrintValues_01(List<int> a_oListValues)
		{
			for(int i = 0; i < a_oListValues.Count; ++i)
			{
				Console.Write("{0}, ", a_oListValues[i]);
			}

			Console.WriteLine();
		}
	}
}
