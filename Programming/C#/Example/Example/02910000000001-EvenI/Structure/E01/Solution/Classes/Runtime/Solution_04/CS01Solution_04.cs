using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Structure.E01.Solution.Classes.Runtime.Solution_04
{
	/**
	 * Solution 4
	 */
	internal class CS01Solution_04
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			var oRandom = new Random();
			var oPQueueValues = new CS01Queue_Priority_04<int>();

			Console.WriteLine("=====> 입력 순서 <=====");

			for(int i = 0; i < 10; ++i)
			{
				int nVal = oRandom.Next(1, 100);
				oPQueueValues.Enqueue(nVal);

				Console.Write("{0}, ", nVal);
			}

			Console.WriteLine("\n\n=====> 우선 순위 큐 요소 <=====");

			while(oPQueueValues.NumValues > 0)
			{
				Console.Write("{0}, ", oPQueueValues.Dequeue());
			}

			Console.WriteLine();
		}
	}
}
