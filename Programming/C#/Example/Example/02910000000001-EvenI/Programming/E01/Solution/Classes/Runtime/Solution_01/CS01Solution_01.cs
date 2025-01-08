using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_01
{
	/**
	 * Solution 1
	 */
	internal class CS01Solution_01
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			Console.WriteLine("ABC");
			Console.WriteLine("{0}", "ABC");
			Console.WriteLine("{0}{1}{2}", 'A', 'B', 'C');
			Console.WriteLine("{0}{1}{2}", (char)65, (char)66, (char)67);	
			Console.WriteLine("{0:X}{1:X}{2:X}", 0xA, 0xB, 0xC);
		}
	}
}
