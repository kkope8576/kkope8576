using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_10
{
	/**
	 * Solution 10
	 */
	class CS01Solution_10
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			var oAnswer = new List<int>();
			S01SetupAnswer_10(oAnswer);

			Console.Write("정답 : ");

			for(int i = 0; i < oAnswer.Count; ++i)
			{
				Console.Write("{0} ", oAnswer[i]);
			}

			Console.WriteLine("\n");

			do
			{
				Console.Write("숫자 입력 : ");
				var oTokens = Console.ReadLine().Split();

				int nNumStrikes = 0;
				int nNumBalls = 0;

				for(int i = 0; i < oAnswer.Count; ++i)
				{
					int j = 0;

					for(j = 0; j < oTokens.Length; ++j)
					{
						int.TryParse(oTokens[j], out int nVal);

						// 숫자가 존재 할 경우
						if(oAnswer[i] == nVal)
						{
							break;
						}
					}

					nNumStrikes += (j < oTokens.Length && i == j) ? 1 : 0;
					nNumBalls += (j < oTokens.Length && i != j) ? 1 : 0;
				}

				Console.WriteLine("결과 : {0} Strike, {1} Ball", nNumStrikes, nNumBalls);

				// 정답 일 경우
				if(nNumStrikes >= oAnswer.Count)
				{
					break;
				}

				Console.WriteLine();
			} while(true);

			Console.WriteLine("\n프로그램을 종료합니다.");
		}

		/** 정답을 설정한다 */
		private static void S01SetupAnswer_10(List<int> a_oOutListValues)
		{
			var oRandom = new Random();

			while(a_oOutListValues.Count < 4)
			{
				int j = 0;
				int nVal = oRandom.Next(1, 10);

				for(j = 0; j < a_oOutListValues.Count; ++j)
				{
					// 숫자가 존재 할 경우
					if(a_oOutListValues[j] == nVal)
					{
						break;
					}
				}

				// 숫자 설정이 불가능 할 경우
				if(j < a_oOutListValues.Count)
				{
					continue;
				}

				a_oOutListValues.Add(nVal);
			}
		}
	}
}
