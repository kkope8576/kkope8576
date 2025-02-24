using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_03
{
	class CS01Practice_03
	{
		public static void Start(string[] args)
		{
			Random rnd = new Random();
			int random = rnd.Next(1, 100);
			Console.WriteLine("랜덤숫자: {0}\n", random);

			Console.Write("숫자를 입력하세요 :");
			int.TryParse(Console.ReadLine(), out int nVal);

			do
			{
				if(nVal == random)
				{
					Console.WriteLine("정답");
					break;
				}
				else
				{
					if(nVal < random)
					{
						Console.WriteLine("정답은 {0} 보다 {1}", nVal, (nVal < random) ? "큽니다" : "작습니다");
					}
				}
			}while (true);
		}
	}
}
