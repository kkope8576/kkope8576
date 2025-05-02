using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Example._02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_05;

namespace Example._02910000000001_EvenI.Structure.E01.Solution.Classes.Runtime.Solution_03
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
			var oTreeValues = new CE01Tree_BinarySearch_05<int>();

			for(int i = 0; i < 10; ++i)
			{
				oTreeValues.AddVal(oRandom.Next(1, 100));
			}

			Console.WriteLine("=====> 트리 요소 <=====");

			oTreeValues.Enumerate(CE01Tree_BinarySearch_05<int>.EOrder.LEVEL, (a_nVal) =>
			{
				Console.Write("{0}, ", a_nVal);
			});

			oTreeValues.AddVal(100);
			Console.WriteLine("\n\n=====> 트리 요소 - 추가 후 <=====");

			oTreeValues.Enumerate(CE01Tree_BinarySearch_05<int>.EOrder.LEVEL, (a_nVal) =>
			{
				Console.Write("{0}, ", a_nVal);
			});

			oTreeValues.RemoveVal(100);
			Console.WriteLine("\n\n=====> 트리 요소 - 제거 후 <=====");

			oTreeValues.Enumerate(CE01Tree_BinarySearch_05<int>.EOrder.LEVEL, (a_nVal) =>
			{
				Console.Write("{0}, ", a_nVal);
			});

			Console.WriteLine();
		}
	}
}
