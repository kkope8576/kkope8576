using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Algorithm.E01.Practice.Classes.Runtime.Practice_01
{
	internal class CP01Practice_01
	{
		public static void Start(string[] args)
		{
			var oRandom = new Random();
			var oListValues = new List<int>();

			for(int i = 0; i < 10; ++i)
			{
				oListValues.Add(oRandom.Next(1, 100));
			}

			oListValues.Sort();
			
			Console.WriteLine("=====> 리스트 요소 <=====");
			P01PrintValues(oListValues);

			Console.Write("\n정수 입력 : ");
			int.TryParse(Console.ReadLine(), out int nVal);

			int nLeft = 0;
			int nRight = oListValues.Count - 1;
			int nResult = P01FindVal(oListValues, nVal, nLeft, nRight);
			Console.WriteLine("결과 : {0}", nResult);
		}
		private static void P01PrintValues(List<int> a_oListValues)
		{
			for(int i = 0; i < a_oListValues.Count; ++i)
			{
				Console.Write("{0}, ", a_oListValues[i]);
			}

			Console.WriteLine();
		}
		
		private static int P01FindVal(List<int> a_oListValues, int a_nVal, int nLeft, int nRight)
		{
			if(nLeft > nRight)
				return -1;
					
			int mid = (nLeft + nRight) / 2;

			if(a_nVal ==  a_oListValues[mid])
				return mid;

			if(a_nVal < a_oListValues[mid])
				return P01FindVal(a_oListValues, a_nVal, nLeft, mid - 1);
			else
				return P01FindVal(a_oListValues, a_nVal, mid + 1, nRight);
		}
	}
}
