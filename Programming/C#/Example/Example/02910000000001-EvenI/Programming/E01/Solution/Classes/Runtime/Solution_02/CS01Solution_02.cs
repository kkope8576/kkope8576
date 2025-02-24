#define P_S01_SOLUTION_02_01
#define P_S01_SOLUTION_02_02

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_02
{
	/**
	 * Solution 2
	 */
	class CS01Solution_02
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if P_S01_SOLUTION_02_01
			Console.Write("점수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nScore);

			Console.Write("결과 : ");

			if(nScore < 60)
			{
				Console.Write("F");
			}
			else
			{
				if(nScore >= 90)
				{
					Console.Write("A");
				}
				else if(nScore >= 80)
				{
					Console.Write("B");
				}
				else if(nScore >= 70)
				{
					Console.Write("C");
				}
				else
				{
					Console.Write("D");
				}

				int nScore_Detail = nScore % 10;

				if(nScore >= 100 || nScore_Detail >= 7)
				{
					Console.Write("+");
				}
				else
				{
					Console.Write("{0}", (nScore_Detail <= 3) ? '-' : '0');
				}
			}

			Console.WriteLine(" 학점입니다.");
#elif P_S01_SOLUTION_02_02
			Console.Write("점수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nScore);

			Console.Write("결과 : ");

			switch(nScore / 60)
			{
				case 1:
					switch(nScore / 10)
					{
						case 9:
						case 10:
							Console.Write("A");
							break;

						case 8:
							Console.Write("B");
							break;

						case 7:
							Console.Write("C");
							break;

						default:
							Console.Write("D");
							break;
					}

					switch(nScore % 10)
					{
						case 7:
						case 8:
						case 9:
							Console.Write("+");
							break;

						case 6:
						case 5:
						case 4:
							Console.Write("0");
							break;

						default:
							Console.Write("{0}", (nScore >= 100) ? '+' : '-');
							break;
					}

					break;

				default:
					Console.Write("F");
					break;
			}

			Console.WriteLine(" 학점입니다.");
#endif // #if P_S01_SOLUTION_02_01
		}
	}
}
