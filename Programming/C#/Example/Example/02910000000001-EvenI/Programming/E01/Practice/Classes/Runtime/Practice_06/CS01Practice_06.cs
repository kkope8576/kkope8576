using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_06
{
	class CS01Practice_06
	{
		public static void Start(string[] args)
		{
			Console.WriteLine("소지 금액 입력:");
			int.TryParse(Console.ReadLine(), out int nAmount);

			const int a = 100;
			const int b = 250;
			const int c = 500;

			for(int i = 0; i * a <= nAmount; i++)
			{
				for(int j = 0; j * b <= nAmount; j++)
				{
					for(int k = 0; k * c <= nAmount; k++)
					{
						if(i * a + j * b + k * c == nAmount)
						{
							Console.WriteLine($"100 원 제품 x {i} 개, 250 원 제품 x {j} 개, 500 원 제품 x {k} 개");
						}
					}
				}
			}

		}
	}
}
