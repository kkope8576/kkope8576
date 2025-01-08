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
	internal class CS01Solution_11
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			Console.Write("크기 (너비, 높이) 입력 : ");
			var oTokens = Console.ReadLine().Split();

			int.TryParse(oTokens[0], out int nWidth);
			int.TryParse(oTokens[1], out int nHeight);
		}
	}
}
