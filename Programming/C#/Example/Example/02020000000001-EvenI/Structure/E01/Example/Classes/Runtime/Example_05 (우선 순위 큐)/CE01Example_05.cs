using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02020000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_05
{
	/**
	 * Example 5
	 */
	internal class CE01Example_05
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			var oRandom = new Random();
			var oQueueValues = new CE01Queue_Priority_05<int>();

			Console.WriteLine("=====> 입력 순서 <=====");

			for(int i = 0; i < 10; ++i)
			{
				int nVal = oRandom.Next(1, 100);
				oQueueValues.Enqueue(nVal);

				Console.Write("{0}, ", nVal);
			}

			Console.WriteLine("\n\n=====> 우선 순위 큐 요소 <=====");

			while(oQueueValues.NumValues > 0)
			{
				Console.Write("{0}, ", oQueueValues.Dequeue());
			}

			Console.WriteLine();
		}
	}
}
