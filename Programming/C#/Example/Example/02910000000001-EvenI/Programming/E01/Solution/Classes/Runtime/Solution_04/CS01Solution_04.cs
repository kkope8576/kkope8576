//#define P_S01_SOLUTION_04_01
#define P_S01_SOLUTION_04_02

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_04
{
	/**
	 * Solution 4
	 */
	class CS01Solution_04
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			var oRandom = new Random();

			int nTimes_Draw = 0;
			int nTimes_Win = 0;
			int nTimes_Lose = 0;

			do
			{
				Console.Write("숫자 (1. 바위, 2. 가위, 3. 보) 입력 : ");
				int.TryParse(Console.ReadLine(), out int nSelect);

				int nSelect_Computer = oRandom.Next(1, 4);
				int nResult = S01GetResult_04(nSelect, nSelect_Computer);

				nTimes_Draw += (nResult == 0) ? 1 : 0;
				nTimes_Win += (nResult == 1) ? 1 : 0;
				nTimes_Lose += (nResult == 2) ? 1 : 0;

				Console.WriteLine("결과 : {0} (나 - {1}, 컴퓨터 - {2})\n",
					S01GetStr_Result_04(nResult), S01GetStr_Select_04(nSelect), S01GetStr_Select_04(nSelect_Computer));
			} while(nTimes_Lose <= 0);

			Console.WriteLine("전적 : {0} 승 {1} 무 {2} 패",
				nTimes_Win, nTimes_Draw, nTimes_Lose);

			Console.WriteLine("프로그램을 종료합니다.");
		}

		/** 선택을 반환한다 */
		private static string S01GetStr_Select_04(int a_nSelect)
		{
			var oStrings_Select = new string[]
			{
				string.Empty, "바위", "가위", "보"
			};

			return oStrings_Select[a_nSelect];
		}

		/** 결과를 반환한다 */
		private static string S01GetStr_Result_04(int a_nResult)
		{
			var oStrings_Result = new string[]
			{
				"무승부", "승리", "패배"
			};

			return oStrings_Result[a_nResult];
		}

#if P_S01_SOLUTION_04_01
		/** 결과를 반환한다 */
		private static int S01GetResult_04(int a_nSelect, int a_nSelect_Computer)
		{
			// 무승부 일 경우
			if(a_nSelect == a_nSelect_Computer)
			{
				return 0;
			}

			return ((a_nSelect % 3) + 1 == a_nSelect_Computer) ? 1 : 2;
		}
#elif P_S01_SOLUTION_04_02
		/** 결과를 반환한다 */
		private static int S01GetResult_04(int a_nSelect, int a_nSelect_Computer)
		{
			var oResults = new int[3, 3]
			{
				{ 0, 1, 2 },
				{ 2, 0, 1 },
				{ 1, 2, 0 }
			};

			return oResults[a_nSelect - 1, a_nSelect_Computer - 1];
		}
#endif // #if P_S01_SOLUTION_04_01
	}
}
