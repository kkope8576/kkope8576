using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Structure.E01.Practice.Classes.Runtime.Practice_02
{
	/**
	 * Practice 2
	 */
	internal class CP01Practice_02
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			var oRandom = new Random();
			var oListValues = new CE01List_Linked_03<int>();

			for(int i = 0; i < 10; ++i)
			{
				oListValues.AddVal(oRandom.Next(1, 100));
			}

			Console.WriteLine("=====> 리스트 요소 <=====");

			for(int i = 0; i < oListValues.NumValues; ++i)
			{
				Console.Write("{0}, ", oListValues[i]);
			}

			Console.WriteLine("\n\n=====> 리스트 요소 - 추가 후 <=====");
			oListValues.InsertVal(0, 100);

			for(int i = 0; i < oListValues.NumValues; ++i)
			{
				Console.Write("{0}, ", oListValues[i]);
			}

			Console.WriteLine();
		}
	}
}
