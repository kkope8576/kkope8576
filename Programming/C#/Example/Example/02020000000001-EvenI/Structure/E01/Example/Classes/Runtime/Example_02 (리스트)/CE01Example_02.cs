#define S_EXAMPLE_E01_EXAMPLE_02_01
#define S_EXAMPLE_E01_EXAMPLE_02_02

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02020000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_02
{
	/**
	 * Example 2
	 */
	internal class CE01Example_02
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if S_EXAMPLE_E01_EXAMPLE_02_01
			var oRandom = new Random();
			var oListValues = new CE01List_Array_02<int>();

			for(int i = 0; i < 10; ++i)
			{
				oListValues.AddVal(oRandom.Next(1, 100));
			}

			Console.WriteLine("=====> 리스트 요소 <=====");
			E01PrintValues_02(oListValues);

			oListValues.InsertVal(0, 100);

			Console.WriteLine("\n=====> 리스트 요소 - 추가 후 <=====");
			E01PrintValues_02(oListValues);

			oListValues.RemoveVal(100);

			Console.WriteLine("\n=====> 리스트 요소 - 제거 후 <=====");
			E01PrintValues_02(oListValues);
#elif S_EXAMPLE_E01_EXAMPLE_02_02
			var oRandom = new Random();
			var oListValues = new CE01List_Linked_02<int>();

			for(int i = 0; i < 10; ++i)
			{
				oListValues.AddVal(oRandom.Next(1, 100));
			}

			Console.WriteLine("=====> 리스트 요소 <=====");
			E01PrintValues_02(oListValues);

			oListValues.InsertVal(0, 100);

			Console.WriteLine("\n=====> 리스트 요소 - 추가 후 <=====");
			E01PrintValues_02(oListValues);

			oListValues.RemoveVal(100);

			Console.WriteLine("\n=====> 리스트 요소 - 제거 후 <=====");
			E01PrintValues_02(oListValues);
#endif // #if S_EXAMPLE_E01_EXAMPLE_02_01
		}

#if S_EXAMPLE_E01_EXAMPLE_02_01
		/** 값을 출력한다 */
		private static void E01PrintValues_02<T>(CE01List_Array_02<T> a_oListValues) where T : IComparable
		{
			for(int i = 0; i < a_oListValues.NumValues; ++i)
			{
				Console.Write("{0}, ", a_oListValues[i]);
			}

			Console.WriteLine();
		}
#elif S_EXAMPLE_E01_EXAMPLE_02_02
		/** 값을 출력한다 */
		private static void E01PrintValues_02<T>(CE01List_Linked_02<T> a_oListValues) where T : IComparable
		{
			for(int i = 0; i < a_oListValues.NumValues; ++i)
			{
				Console.Write("{0}, ", a_oListValues[i]);
			}

			Console.WriteLine();
		}
#endif // #if S_EXAMPLE_E01_EXAMPLE_02_01
	}
}
