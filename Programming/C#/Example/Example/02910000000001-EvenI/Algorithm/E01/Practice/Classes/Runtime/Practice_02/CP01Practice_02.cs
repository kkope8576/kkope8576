using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Algorithm.E01.Practice.Classes.Runtime.Practice_02
{
	internal class CP01Practice_02
	{
		public static void Start(string[] args)
		{
			var oRandom = new Random();
			var oList = new List<int>();

			for(int i = 0; i < 10; ++i)
			{
				oList.Add(oRandom.Next(1, 100));
			}

			Console.WriteLine("=====> 리스트 요소 - 정렬 전 <=====");
			Print(oList);

			QuickSortValues(oList, E01Compare_ByAscending_04);

			Console.WriteLine("\n=====> 리스트 요소 - 정렬 후 (오름차순) <=====");
			Print(oList);

			QuickSortValues(oList, E01Compare_ByDescending_04);

			Console.WriteLine("\n=====> 리스트 요소 - 정렬 후 (내림차순) <=====");
			Print(oList);
		}
			/** 오름차순으로 비교한다 */
		private static int E01Compare_ByAscending_04(int a_nLhs, int a_nRhs)
		{
			return a_nLhs - a_nRhs;
		}

		/** 내림차순으로 비교한다 */
		private static int E01Compare_ByDescending_04(int a_nLhs, int a_nRhs)
		{
			return a_nRhs - a_nLhs;
		}

		/** 값을 출력한다 */
		private static void Print(List<int> a_oListValues)
		{
			for(int i = 0; i < a_oListValues.Count; ++i)
			{
				Console.Write("{0}, ", a_oListValues[i]);
			}

			Console.WriteLine();
		}

		private static void QuickSortValues(List<int> nList, Func<int, int, int> oCompare)
		{
			QuickSort(nList, 0, nList.Count - 1, oCompare);
		}

		private static void QuickSort(List<int> nListValues, int nLeft, int nRight, Func<int, int, int> oCompare)
		{
			if(nLeft >= nRight)
			{
				return;
			}

			Random random = new Random();
			int nPivot = random.Next(nLeft, nRight + 1);

			
			int nTemp = nListValues[nPivot];
			nListValues[nPivot] = nListValues[nLeft];
			nListValues[nLeft] = nTemp;

			int pivotValue = nListValues[nLeft]; 
			int nLeftValues = nLeft + 1;
			int nRightValues = nRight;

			
			while(nLeftValues <= nRightValues)
			{
				while(nLeftValues <= nRightValues && oCompare(nListValues[nLeftValues], pivotValue) <= 0)
				{
					nLeftValues++;
				}

				while(nLeftValues <= nRightValues && oCompare(nListValues[nRightValues], pivotValue) > 0)
				{
					nRightValues--;
				}

				if(nLeftValues < nRightValues)
				{
					int oTemp = nListValues[nLeftValues];
					nListValues[nLeftValues] = nListValues[nRightValues];
					nListValues[nRightValues] = oTemp;
				}
			}

			
			int tempPivot = nListValues[nLeft];
			nListValues[nLeft] = nListValues[nRightValues];
			nListValues[nRightValues] = tempPivot;

			
			QuickSort(nListValues, nLeft, nRightValues - 1, oCompare);
			QuickSort(nListValues, nRightValues + 1, nRight, oCompare);
		}


	}
}
