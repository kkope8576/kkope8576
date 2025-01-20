using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_05
{
	internal class CS01Practice_05
	{
		public static void Start(string[] args)
		{
			Console.WriteLine("라인 수 입력 :");
			int.TryParse(Console.ReadLine(), out int nLine);

			for(int i = 0; i < nLine; ++i)
			{
				for(int j = nLine - 1; j > i; --j)
				{
					Console.Write(" ");
				}

				for(int j = 0; j < 2 * i + 1; ++j)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

			Console.WriteLine();

			for(int i = nLine - 1; i >= 0; --i)
			{
				for(int j = nLine - 1; j > i; --j)
				{
					Console.Write(" ");
				}

				for(int j = 0; j < 2 * i + 1; ++j)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}
		}
	}
}
