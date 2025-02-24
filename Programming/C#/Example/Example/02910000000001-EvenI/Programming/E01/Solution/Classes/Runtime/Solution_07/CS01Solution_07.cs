using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_07
{
	/**
	 * Solution 7
	 */
	class CS01Solution_07
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			Console.Write("크기 입력 : ");
			int.TryParse(Console.ReadLine(), out int nSize);

			var oValues = new int[nSize, nSize];
			S01SetupValues_07(oValues);

			for(int i = 0; i < oValues.GetLength(0); ++i)
			{
				for(int j = 0; j < oValues.GetLength(1); ++j)
				{
					Console.Write("{0,3} ", oValues[i, j]);
				}

				Console.WriteLine();
			}
		}

		/** 값을 설정한다 */
		private static void S01SetupValues_07(int[,] a_oValues)
		{
			int nVal = 0;
			int nVal_Max = a_oValues.Length;

			int nIdx_X = -1;
			int nIdx_Y = 0;

			int nDirection = 1;
			int nTimes_Move = a_oValues.GetLength(0);

			while(nVal < nVal_Max)
			{
				for(int i = 0; i < nTimes_Move; ++i)
				{
					nIdx_X += nDirection;
					a_oValues[nIdx_Y, nIdx_X] = ++nVal;
				}

				nTimes_Move -= 1;

				for(int i = 0; i < nTimes_Move; ++i)
				{
					nIdx_Y += nDirection;
					a_oValues[nIdx_Y, nIdx_X] = ++nVal;
				}

				nDirection = -nDirection;
			}
		}
	}
}
