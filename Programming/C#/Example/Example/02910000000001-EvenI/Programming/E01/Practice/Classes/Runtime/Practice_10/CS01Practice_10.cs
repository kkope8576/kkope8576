using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_10
{
	class CS01Practice_10
	{
		public static void Start(string[] args)
		{
			var oRandom = new Random();
			var oNumbers = new int[4];

			for(int i = 0; i < oNumbers.Length; i++)
			{
				int number;
				bool oDuplicate;

				do
				{
					number = oRandom.Next(1, 10);
					oDuplicate = false;

					for(int j = 0; j < i; j++)
					{
						if(oNumbers[j] == number)
						{
							oDuplicate = true;
							break;
						}
					}
				} while(oDuplicate);

				oNumbers[i] = number;
			}

			for(int i = 0; i < oNumbers.Length; ++i)
			{
				Console.Write("{0} ", oNumbers[i]);
			}

			Console.WriteLine("\n");

			while(true)
			{
				Console.WriteLine("숫자를 입력하세요 :");
				string oInput = Console.ReadLine();
				string[] oInputNumbers = oInput.Split(' ');

				int[] oUserNumbers = new int[4];
				for(int i = 0; i < 4; i++)
				{
					oUserNumbers[i] = int.Parse(oInputNumbers[i]);
				}

				int strikes = 0;
				int balls = 0;

				for(int i = 0; i < 4; i++)
				{
					for(int j = 0; j < 4; j++)
					{
						if(oUserNumbers[i] == oNumbers[j])
						{
							if(i == j)
								strikes++;
							else
								balls++;
						}
					}
				}

				Console.WriteLine($"스트라이크 : {strikes}, 볼 : {balls}");

				if(strikes == 4)
				{
					break;
				}
			}
		}
	}
}
