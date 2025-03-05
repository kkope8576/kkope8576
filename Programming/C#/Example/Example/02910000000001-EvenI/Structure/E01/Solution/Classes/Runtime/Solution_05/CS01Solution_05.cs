using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Structure.E01.Solution.Classes.Runtime.Solution_05
{
	/**
	 * Solution 5
	 */
	class CS01Solution_05
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			var oRandom = new Random();
			var oHashValues = new CS01HashTable_Chaining_05<int>();

			for(int i = 0; i < 10; ++i)
			{
				oHashValues.AddVal(oRandom.Next(1, 100));
			}

			Console.WriteLine("=====> 해시 요소 <=====");

			oHashValues.Enumerate((a_nIdx, a_nVal) =>
			{
				Console.Write("{0}:{1}, ", a_nIdx, a_nVal);
			});

			Console.WriteLine();
		}
	}
}
