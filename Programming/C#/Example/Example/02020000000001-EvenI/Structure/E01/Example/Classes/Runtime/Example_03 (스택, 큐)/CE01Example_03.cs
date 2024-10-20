using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02020000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_03
{
	/**
	 * Example 3
	 */
	internal class CE01Example_03
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			var oStackValues = new CE01Stack_03<int>();
			var oQueueValues = new CE01Queue_03<int>();

			Console.WriteLine("=====> 입력 순서 <=====");

			for(int i = 0; i < 10; ++i)
			{
				oStackValues.Push(i + 1);
				oQueueValues.Enqueue(i + 1);

				Console.Write("{0}, ", i + 1);
			}

			Console.WriteLine("\n\n=====> 스택 요소 <=====");

			while(oStackValues.NumValues > 0)
			{
				Console.Write("{0}, ", oStackValues.Pop());
			}

			Console.WriteLine("\n\n=====> 큐 요소 <=====");

			while(oQueueValues.NumValues > 0)
			{
				Console.Write("{0}, ", oQueueValues.Dequeue());
			}

			Console.WriteLine();
		}
	}
}
