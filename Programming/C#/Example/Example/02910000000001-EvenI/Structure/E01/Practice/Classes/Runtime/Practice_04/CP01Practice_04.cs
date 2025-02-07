using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Structure.E01.Practice.Classes.Runtime.Practice_04
{
	internal class CP01Practice_04<T> where T : IComparable
	{
		CP01Practice_04<int> queue = new CP01Practice_04<int>();
		public int NumValues { get; private set; } = 1;
		public T[] Values { get; private set; } = null;
		public CP01Practice_04(int a_nSize = 5)
		{
			this.Values = new T[a_nSize + 1];
		}

		public void Enqueue(T a_tVal)
		{
			if(this.NumValues >= this.Values.Length)
			{
				var oValues = this.Values;
				Array.Resize(ref oValues, this.Values.Length * 2);

				this.Values = oValues;
			}

			this.Values[this.NumValues++] = a_tVal;
			int nIdx = this.NumValues;

			while(nIdx > 1)
			{
				int nIdx_Parent = (nIdx) / 2;

				if(this.Values[nIdx_Parent].CompareTo(this.Values[nIdx]) < 0)
				{
					break;
				}

				T tTemp = this.Values[nIdx];
				this.Values[nIdx] = this.Values[nIdx_Parent];
				this.Values[nIdx_Parent] = tTemp;

				nIdx = nIdx_Parent;
			}
		}

		public T Dequeue()
		{
			T tVal = this.Values[1];
			this.Values[1] = this.Values[this.NumValues - 1];

			this.NumValues -= 1;
			int nIdx = 1;

			while(nIdx <= this.NumValues / 2)
			{
				int nIdx_Compare = (nIdx * 2);

				if(nIdx_Compare + 1 < this.NumValues)
				{
					int nIdx_RChild = nIdx_Compare + 1;

					nIdx_Compare = (this.Values[nIdx_Compare].CompareTo(this.Values[nIdx_RChild]) < 0) ?
						nIdx_Compare : nIdx_RChild;
				}
				if(this.Values[nIdx].CompareTo(this.Values[nIdx_Compare]) < 0)
				{
					break;
				}

				T tTemp = this.Values[nIdx];
				this.Values[nIdx] = this.Values[nIdx_Compare];
				this.Values[nIdx_Compare] = tTemp;

				nIdx = nIdx_Compare;
			}


			return tVal;
		}
	}
}
