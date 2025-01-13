using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_04
{
	internal class CS01Practice_04
	{
		public static void Main(string[] args)
		{
			int wins = 0;
			int draws = 0;
			int lose = 0;
			do
			{
				Console.Write("가위(1), 바위(2), 보(3) :");
				int.TryParse(Console.ReadLine(), out int nVal);
				Random rnd = new Random();
				int random = rnd.Next(1, 4);
				Console.WriteLine("가위바위보 : {0}\n", random);

				if(random == nVal)
				{
					Console.WriteLine("무승부");
					draws++;
				}
				else if((random == 1 && nVal == 3) ||
						 (random == 2 && nVal == 1) ||
						 (random == 3 && nVal == 2))
				{
					Console.WriteLine("승리");
					wins++;
				}
				else
				{
					Console.WriteLine("패배");
					lose++;
					break;
				}
			} while(true);

			Console.WriteLine("전적 :");
			Console.WriteLine("승리 : {0}", wins);
			Console.WriteLine("패배 : {0}", lose);
			Console.WriteLine("무승부 : {0}", draws);
		}
	}
}
