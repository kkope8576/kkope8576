#define P_PRACTICE_P01_PRACTICE_02_01
#define P_PRACTICE_P01_PRACTICE_02_02
#define P_PRACTICE_P01_PRACTICE_02_03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02020000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_02
{
	/**
	 * Practice 2
	 */
	internal class CP01Practice_02
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if P_PRACTICE_P01_PRACTICE_02_01
			Console.Write("개수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nNumValues);

			int nIdx_Odd = 0;
			int nIdx_Even = nNumValues - 1;

			var oValues = new int[nNumValues];

			for(int i = 0; i < nNumValues; ++i)
			{
				Console.Write("정수 {0} 입력 : ", i + 1);
				int.TryParse(Console.ReadLine(), out int nVal);

				// 홀수 일 경우
				if(nVal % 2 != 0)
				{
					oValues[nIdx_Odd++] = nVal;
				}
				else
				{
					oValues[nIdx_Even--] = nVal;
				}
			}

			Console.WriteLine("\n=====> 배열 요소 <=====");

			for(int i = 0; i < nNumValues; ++i)
			{
				Console.Write("{0}, ", oValues[i]);
			}

			Console.WriteLine();
#elif P_PRACTICE_P01_PRACTICE_02_02
			int nVal = 0;
			int nNumValues = 0;

			var oValues = new int[5];

			do
			{
				Console.Write("정수 {0} 입력 : ", nNumValues + 1);
				int.TryParse(Console.ReadLine(), out nVal);

				// 값이 유효하지 않을 경우
				if(nVal <= 0)
				{
					continue;
				}

				// 배열이 가득찼을 경우
				if(nNumValues >= oValues.Length)
				{
					var oValues_New = new int[oValues.Length * 2];

					for(int i = 0; i < nNumValues; ++i)
					{
						oValues_New[i] = oValues[i];
					}

					oValues = oValues_New;
				}

				oValues[nNumValues++] = nVal;
			} while(nVal > 0);

			Console.WriteLine("\n=====> 배열 요소 <=====");

			for(int i = 0; i < nNumValues; ++i)
			{
				Console.Write("{0}, ", oValues[i]);
			}

			Console.WriteLine();
#elif P_PRACTICE_P01_PRACTICE_02_03
			Console.Write("정수 입력 : ");
			string oStr_Input = Console.ReadLine();

			var oStrings_Digit = new string[7]
			{
				"*****     * ***** ***** *   * ***** ***** ***** ***** *****",
				"*   *     *     *     * *   * *     *         * *   * *   *",
				"*   *     *     *     * *   * *     *         * *   * *   *",
				"*   *     * ***** ***** ***** ***** *****     * ***** *****",
				"*   *     * *         *     *     * *   *     * *   *     *",
				"*   *     * *         *     *     * *   *     * *   *     *",
				"*****     * ***** *****     * ***** *****     * ***** *****"
			};

			int nWidth_Digit = 5;

			for(int i = 0; i < oStrings_Digit.Length; ++i)
			{
				string oStr_Digit = oStrings_Digit[i];

				for(int j = 0; j < oStr_Input.Length; ++j)
				{
					int.TryParse($"{oStr_Input[j]}", out int nVal);

					for(int k = 0; k < nWidth_Digit; ++k)
					{
						int nIdx_Start = nWidth_Digit * nVal + nVal;
						Console.Write(oStr_Digit[nIdx_Start + k]);
					}

					Console.Write(" ");
				}

				Console.WriteLine();
			}
#endif // #if P_PRACTICE_P01_PRACTICE_02_01
		}
	}
}
