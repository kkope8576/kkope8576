using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Structure.E01.Solution.Classes.Runtime.Solution_04
{
	/**
	 * 우선 순위 큐
	 */
	class CS01Queue_Priority_04<T> where T : IComparable
	{
		public int NumValues_Internal { get; private set; } = 0;
		public T[] Values { get; private set; } = null;

		public int NumValues => this.NumValues_Internal - 1;

		/** 생성자 */
		public CS01Queue_Priority_04(int a_nSize = 5)
		{
			this.Values = new T[a_nSize];
			this.Enqueue(default);
		}

		/** 값을 추가한다 */
		public void Enqueue(T a_tVal)
		{
			// 배열이 가득찼을 경우
			if(this.NumValues_Internal >= this.Values.Length)
			{
				var oValues = this.Values;
				Array.Resize(ref oValues, this.Values.Length * 2);

				this.Values = oValues;
			}

			this.Values[this.NumValues_Internal++] = a_tVal;
			int nIdx = this.NumValues_Internal - 1;

			while(nIdx > 1)
			{
				int nIdx_Parent = nIdx / 2;

				// 정렬이 완료되었을 경우
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

		/** 값을 제거한다 */
		public T Dequeue()
		{
			T tVal = this.Values[1];
			this.Values[1] = this.Values[this.NumValues_Internal - 1];

			this.NumValues_Internal -= 1;
			int nIdx = 1;

			while(nIdx <= this.NumValues_Internal / 2)
			{
				int nIdx_Compare = nIdx * 2;

				// 오른쪽 노드가 존재 할 경우
				if(nIdx_Compare + 1 < this.NumValues_Internal)
				{
					int nIdx_RChild = nIdx_Compare + 1;

					nIdx_Compare = (this.Values[nIdx_Compare].CompareTo(this.Values[nIdx_RChild]) < 0) ?
						nIdx_Compare : nIdx_RChild;
				}

				// 정렬이 완료되었을 경우
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
