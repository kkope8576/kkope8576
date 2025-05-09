using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example._02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_06;

namespace Example._02910000000001_EvenI.Structure.E01.Practice.Classes.Runtime.Practice_04
{
	internal class CP01Practice_04_Que
	{

		public static void Start(string[] args)
		{
			var oRandom = new Random();
			var oPQueueValues = new CP01Practice_04<int>();

			Console.WriteLine("=====> 입력 순서 <=====");

			for(int i = 0; i < 10; ++i)
			{
				int nVal = oRandom.Next(1, 100);
				oPQueueValues.Enqueue(nVal);

				Console.Write("{0}, ", nVal);
			}

			Console.WriteLine("\n\n=====> 우선 순위 큐 <=====");

			while(oPQueueValues.NumValues > 0)
			{
				Console.Write("{0}, ", oPQueueValues.Dequeue());
			}

			Console.WriteLine();
		}
	}
}

