using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_09
{
	/**
	 * Solution 9
	 */
	internal class CS01Solution_09
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			string oAnswer = S01GetAnswer_09();
			Console.WriteLine("정답 : {0}\n", oAnswer);

			var oWord = oAnswer.ToArray();
			var oLetters = new char[oAnswer.Length];

			S01SetupLetters_09(oWord, oLetters);

			do
			{
				S01PrintLetters_09(oLetters);

				Console.Write("문자 입력 : ");
				char.TryParse(Console.ReadLine(), out char chLetter);

				for(int i = 0; i < oWord.Length; ++i)
				{
					// 문자가 다를 경우
					if(char.ToUpper(chLetter) != char.ToUpper(oWord[i]))
					{
						continue;
					}

					oLetters[i] = oWord[i];
				}

				Console.WriteLine();
			} while(!S01IsAnswer_09(oLetters));

			S01PrintLetters_09(oLetters);
			Console.WriteLine("프로그램을 종료합니다.\n");
		}

		/** 문자를 설정한다 */
		private static void S01SetupLetters_09(char[] a_oWord, char[] a_oOutLetters)
		{
			for(int i = 0; i < a_oOutLetters.Length; ++i)
			{
				a_oOutLetters[i] = '_';
			}

			var oRandom = new Random();
			int nLength = (int)(a_oWord.Length * 0.3f);

			for(int i = 0; i < nLength; ++i)
			{
				int nIdx = oRandom.Next(0, a_oWord.Length);
				a_oOutLetters[nIdx] = a_oWord[nIdx];
			}
		}

		/** 정답을 반환한다 */
		private static string S01GetAnswer_09()
		{
			var oWords = new string[]
			{
				"Apple",
				"Samsung",
				"Microsoft"
			};

			var oRandom = new Random();
			return oWords[oRandom.Next(0, oWords.Length)];
		}

		/** 정답 여부를 검사한다 */
		private static bool S01IsAnswer_09(char[] a_oLetters)
		{
			for(int i = 0; i < a_oLetters.Length; ++i)
			{
				// 공백이 존재 할 경우
				if(a_oLetters[i] == '_')
				{
					return false;
				}
			}

			return true;
		}

		/** 문자를 출력한다 */
		private static void S01PrintLetters_09(char[] a_oLetters)
		{
			for(int i = 0; i < a_oLetters.Length; ++i)
			{
				Console.Write("{0} ", a_oLetters[i]);
			}

			Console.WriteLine();
		}
	}
}
