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
			Console.Write("정수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nVal);

			int nResult = P01GetVal_Factorial(nVal);
			Console.WriteLine("!{0} = {1}", nVal, nResult);
#elif P_PRACTICE_P01_PRACTICE_03_03
			Console.Write("정수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nVal);

			int nResult = P01GetVal_Fibonacci(nVal);
			Console.WriteLine("결과 : {0}", nResult);
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
		/** 팩토리얼 값을 반환한다 */
		private static int P01GetVal_Factorial(int a_nVal)
		{
			// 재귀가 불가능 할 경우
			if(a_nVal <= 1)
			{
				return 1;
			}

			/*
			 * 메서든 내부에서 자기 자신을 다시 호출하는 것이 가능하며 이를 재귀 호출이라고한다.
			 * 
			 * 단, 재귀 호출은 자기 자신을 반복해서 호출하는 것이기 때문에 잘못된 명령문을 작성 할
			 * 경우 원치 않는 무한 루프가 발생하는 단점이 존재한다.
			 * 
			 * 따라서 재귀 호출을 사용 할 경우 반드시 특정 시점에 재구를 끝낼 수 있는 조건문을
			 * 반드시 작성해줘야한다.
			 */
			return a_nVal * P01GetVal_Factorial(a_nVal - 1);
		}
#elif P_PRACTICE_P01_PRACTICE_03_03
		/** 피보나치 값을 반환한다 */
		private static int P01GetVal_Fibonacci(int a_nVal)
		{
			// 재귀가 불가능 할 경우
			if(a_nVal <= 1)
			{
				return (a_nVal <= 0) ? 0 : 1;
			}

			return P01GetVal_Fibonacci(a_nVal - 2) + P01GetVal_Fibonacci(a_nVal - 1);
		}
#endif // #if P_PRACTICE_P01_PRACTICE_03_01
	}
}
