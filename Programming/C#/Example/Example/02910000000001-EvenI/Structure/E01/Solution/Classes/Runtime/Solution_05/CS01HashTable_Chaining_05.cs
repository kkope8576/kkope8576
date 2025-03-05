using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Example._02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_05;

namespace Example._02910000000001_EvenI.Structure.E01.Solution.Classes.Runtime.Solution_05
{
	/**
	 * 해시 테이블
	 */
	class CS01HashTable_Chaining_05<T> where T : IComparable
	{
		public CE01Tree_BinarySearch_05<T>[] ContainerTrees { get; private set; } = null;

		/** 생성자 */
		public CS01HashTable_Chaining_05(int a_nSize = 5)
		{
			this.ContainerTrees = new CE01Tree_BinarySearch_05<T>[a_nSize];

			for(int i = 0; i < a_nSize; ++i)
			{
				this.ContainerTrees[i] = new CE01Tree_BinarySearch_05<T>();
			}
		}

		/** 값을 추가한다 */
		public void AddVal(T a_tVal)
		{
			int nKey = this.MakeKey(a_tVal);
			this.ContainerTrees[nKey].AddVal(a_tVal);
		}

		/** 값을 제거한다 */
		public void RemoveVal(T a_tVal)
		{
			int nKey = this.MakeKey(a_tVal);
			this.ContainerTrees[nKey].RemoveVal(a_tVal);
		}

		/** 값을 순회한다 */
		public void Enumerate(Action<int, T> a_oCallback)
		{
			for(int i = 0; i < this.ContainerTrees.Length; ++i)
			{
				this.ContainerTrees[i].Enumerate(CE01Tree_BinarySearch_05<T>.EOrder.IN, (a_tVal) =>
				{
					a_oCallback?.Invoke(i, a_tVal);
				});
			}
		}

		/** 식별자를 생성한다 */
		private int MakeKey(T a_tVal)
		{
			int nKey = a_tVal.GetHashCode();
			return nKey % this.ContainerTrees.Length;
		}
	}
}
