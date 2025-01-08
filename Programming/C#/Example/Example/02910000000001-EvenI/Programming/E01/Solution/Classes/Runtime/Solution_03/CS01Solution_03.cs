using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_03
{
	/**
	 * Solution 3
	 */
	internal class CS01Solution_03
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			var oRandom = new Random();
			int nAnswer = oRandom.Next(1, 100);

			Console.WriteLine("정답 : {0}\n", nAnswer);

			do
			{
				Console.Write("숫자 입력 : ");
				int.TryParse(Console.ReadLine(), out int nVal);

				// 정답 일 경우
				if(nVal == nAnswer)
				{
					break;
				}
				else
				{
#if DISABLE_THIS
					if(nVal < nAnswer)
					{
						Console.WriteLine("정답은 {0} 보다 큽니다.", nVal);
					}
					else
					{
						Console.WriteLine("정답은 {0} 보다 작습니다.", nVal);
					}
#endif // #if DISABLE_THIS

					string oStr = "정답은 {0} 보다 {1}";
					string oStr_Guide = (nVal < nAnswer) ? "큽니다." : "작습니다.";

					Console.WriteLine(oStr, nVal, oStr_Guide);
				}

				Console.WriteLine();
			} while(true);

			Console.WriteLine("프로그램을 종료합니다.");
		}
	}
}
