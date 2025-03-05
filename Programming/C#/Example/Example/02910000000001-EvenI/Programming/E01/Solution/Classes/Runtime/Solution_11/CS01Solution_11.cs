using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_11
{
	/**
	 * Solution 11
	 */
	class CS01Solution_11
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			Console.Write("크기 (너비, 높이) 입력 : ");
			var oTokens = Console.ReadLine().Split();

			int.TryParse(oTokens[0], out int nWidth);
			int.TryParse(oTokens[1], out int nHeight);

			var oValues = new int[nHeight, nWidth];
			S01SetupValues_11(oValues);

			do
			{
				Console.WriteLine("=====> 현재 상태 <=====");
				S01PrintValues_11(oValues);

				Console.Write("\n위치 입력 : ");
				oTokens = Console.ReadLine().Split();

				int.TryParse(oTokens[0], out int nPos_X);
				int.TryParse(oTokens[1], out int nPos_Y);

				nPos_X -= 1;
				nPos_Y -= 1;

				var oOffsets_X = new int[]
				{
					0, 0, -1, 1
				};

				var oOffsets_Y = new int[]
				{
					-1, 1, 0, 0
				};

				for(int i = 0; i < oOffsets_X.Length; ++i)
				{
					int nPos_AroundX = nPos_X + oOffsets_X[i];
					int nPos_AroundY = nPos_Y + oOffsets_Y[i];

					// 배열 범위를 벗어났을 경우
					if(nPos_AroundX < 0 || nPos_AroundX >= oValues.GetLength(1) ||
						nPos_AroundY < 0 || nPos_AroundY >= oValues.GetLength(0))
					{
						continue;
					}

					// 공백이 존재 할 경우
					if(oValues[nPos_AroundY, nPos_AroundX] == 0)
					{
						int nTemp = oValues[nPos_Y, nPos_X];
						oValues[nPos_Y, nPos_X] = oValues[nPos_AroundY, nPos_AroundX];
						oValues[nPos_AroundY, nPos_AroundX] = nTemp;

						break;
					}
				}

				Console.WriteLine();
			} while(!S01IsAnswer_11(oValues));

			Console.WriteLine("=====> 현재 상태 <=====");
			S01PrintValues_11(oValues);
		}

		/** 값을 설정한다 */
		private static void S01SetupValues_11(int[,] a_oValues)
		{
			for(int i = 0; i < a_oValues.GetLength(0); ++i)
			{
				for(int j = 0; j < a_oValues.GetLength(1); ++j)
				{
					int nIdx = (i * a_oValues.GetLength(1)) + j;
					a_oValues[i, j] = nIdx;
				}
			}

			var oRandom = new Random();

			for(int i = 0; i < a_oValues.GetLength(0); ++i)
			{
				for(int j = 0; j < a_oValues.GetLength(1); ++j)
				{
					int nRow = oRandom.Next(0, a_oValues.GetLength(0));
					int nCol = oRandom.Next(0, a_oValues.GetLength(1));

					int nTemp = a_oValues[i, j];
					a_oValues[i, j] = a_oValues[nRow, nCol];
					a_oValues[nRow, nCol] = nTemp;
				}
			}
		}

		/** 정답 여부를 검사한다 */
		private static bool S01IsAnswer_11(int[,] a_oValues)
		{
			for(int i = 0; i < a_oValues.GetLength(0); ++i)
			{
				for(int j = 0; j < a_oValues.GetLength(1); ++j)
				{
					int nVal = (i * a_oValues.GetLength(1)) + j;
					nVal = (nVal + 1) % a_oValues.Length;

					// 값이 다를 경우
					if(a_oValues[i, j] != nVal)
					{
						return false;
					}
				}
			}

			return true;
		}

		/** 값을 출력한다 */
		private static void S01PrintValues_11(int[,] a_oValues)
		{
			for(int i = 0; i < a_oValues.GetLength(0); ++i)
			{
				for(int j = 0; j < a_oValues.GetLength(1); ++j)
				{
					Console.Write("{0,4}",
						(a_oValues[i, j] == 0) ? " " : $"{a_oValues[i, j]}");
				}

				Console.WriteLine();
			}
		}
	}
}
