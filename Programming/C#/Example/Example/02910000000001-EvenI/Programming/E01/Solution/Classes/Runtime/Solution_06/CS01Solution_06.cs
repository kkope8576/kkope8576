//#define P_S01_SOLUTION_06_01
#define P_S01_SOLUTION_06_02

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_06
{
	/**
	 * Solution 6
	 */
	internal class CS01Solution_06
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			Console.Write("소지 금액 입력 : ");
			int.TryParse(Console.ReadLine(), out int nAmount);

#if P_S01_SOLUTION_06_01
			const int nCost_ObjA = 100;
			const int nCost_ObjB = 250;
			const int nCost_ObjC = 500;

			for(int i = 0; i <= nAmount; i += nCost_ObjA)
			{
				for(int j = 0; j <= nAmount; j += nCost_ObjB)
				{
					for(int k = 0; k <= nAmount; k += nCost_ObjC)
					{
						// 제품 구입이 불가능 할 경우
						if(i + j + k != nAmount)
						{
							continue;
						}

						int nNumObjectsA = i / nCost_ObjA;
						int nNumObjectsB = j / nCost_ObjB;
						int nNumObjectsC = k / nCost_ObjC;

						Console.WriteLine("{0} 원 제품 x {1} 개, {2} 원 제품 x {3} 개, {4} 원 제품 x {5} 개",
							nCost_ObjA, nNumObjectsA, nCost_ObjB, nNumObjectsB, nCost_ObjC, nNumObjectsC);
					}
				}
			}
#elif P_S01_SOLUTION_06_02
			var oListCosts_Obj = new List<int>()
			{
				100, 250, 500
			};

			var oListNumObjects = new List<int>(new int[oListCosts_Obj.Count]);
			S01PrintCases_06(oListCosts_Obj, oListNumObjects, 0, nAmount);
#endif // #if P_S01_SOLUTION_06_01
		}

#if P_S01_SOLUTION_06_02
		/** 경우의 수를 출력한다 */
		private static void S01PrintCases_06(List<int> a_oListCosts_Obj,
			List<int> a_oListNumObjects, int a_nIdx_Obj, int a_nAmount)
		{
			// 제품 구입이 불가능 할 경우
			if(a_nAmount <= 0 || a_nIdx_Obj >= a_oListCosts_Obj.Count)
			{
				// 금액을 모두 소비했을 경우
				if(a_nAmount == 0)
				{
					S01PrintObjects_06(a_oListCosts_Obj, a_oListNumObjects);
				}

				return;
			}

			for(int i = 0; i <= a_nAmount; i += a_oListCosts_Obj[a_nIdx_Obj])
			{
				a_oListNumObjects[a_nIdx_Obj] = i / a_oListCosts_Obj[a_nIdx_Obj];

				S01PrintCases_06(a_oListCosts_Obj,
					a_oListNumObjects, a_nIdx_Obj + 1, a_nAmount - i);
			}

			a_oListNumObjects[a_nIdx_Obj] = 0;
		}

		/** 제품을 출력한다 */
		private static void S01PrintObjects_06(List<int> a_oListCosts_Obj,
			List<int> a_oListNumObjects)
		{
			for(int i = 0; i < a_oListCosts_Obj.Count; ++i)
			{
				Console.Write("{0} 원 제품 x {1} 개, ",
					a_oListCosts_Obj[i], a_oListNumObjects[i]);
			}

			Console.WriteLine();
		}
#endif // #if P_S01_SOLUTION_06_02
	}
}
