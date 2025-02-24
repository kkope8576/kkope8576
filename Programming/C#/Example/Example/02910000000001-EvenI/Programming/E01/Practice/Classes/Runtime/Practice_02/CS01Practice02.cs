using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_02
{
	class CS01Practice_02
	{
		public static void Start(string[] args)
		{
			Console.Write("점수를 입력하세요 : ");
			int.TryParse(Console.ReadLine(), out int nval);

			//
			if(nval >= 90)
			{
				Console.Write("A");
			}
			else if(nval >= 80)
			{
				Console.Write("B");
			}
			else if(nval >= 70)
			{
				Console.Write("C");
			}
			else if(nval >= 60)
			{
				Console.Write("D");
			}
			else
			{
				Console.Write("F");
			}
			Console.WriteLine("학점입니다.");
		}
	}
}
