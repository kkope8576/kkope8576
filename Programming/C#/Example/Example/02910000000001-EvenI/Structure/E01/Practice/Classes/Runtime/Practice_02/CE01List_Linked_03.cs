using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Structure.E01.Practice.Classes.Runtime.Practice_02
{
	internal class CE01List_Linked_03<T> where T : IComparable
	{
		public class CNode
		{
			public T Val { get; set; }
			public CNode Node_Next { get; set; } = null;
		}
		public int NumValues { get; private set; } = 0;
		public CNode Node_Head { get; private set; } = null;
		public CNode Node_Tail { get; private set; } = null;

		public T this[int a_nIdx]
		{
			get
			{
				return this.FindNodeAt(a_nIdx).Val;
			}
			set
			{
				var oNode = this.FindNodeAt(a_nIdx);
				oNode.Val = value;
			}
		}
		public void AddVal(T a_tVal)
		{
			var oNode = this.CreateNode(a_tVal);
			if(this.Node_Head == null)
			{
				this.Node_Head = oNode;
				this.Node_Tail = oNode;
				this.Node_Tail.Node_Next = this.Node_Head;
			}
			else
			{
				this.Node_Tail.Node_Next = oNode;
				this.Node_Tail = oNode;
				this.Node_Tail.Node_Next = this.Node_Head;
			}
			this.NumValues += 1;
		}
		public void InsertVal(int a_nIdx, T a_tVal)
		{
			var oNode_Next = this.FindNodeAt(a_nIdx);
			var oNode_Prev = this.FindNodeAt(a_nIdx - 1);

			var oNode = this.CreateNode(a_tVal);

			if(oNode_Next == null)
			{
				this.Node_Head = oNode;
				this.Node_Tail = oNode;
				this.Node_Tail.Node_Next = this.Node_Head;
			}
			else
			{
				oNode.Node_Next = oNode_Next;

				// 이전 노드가 없을 경우
				if(oNode_Prev == null)
				{
					this.Node_Head = oNode;
					this.Node_Tail.Node_Next = oNode;
				}
				else
				{
					oNode_Prev.Node_Next = oNode;
				}
			}

			this.NumValues += 1;
		}
		private CNode FindNodeAt(int a_nIdx)
		{
			if(a_nIdx < 0)
			{
				return null;
			}

			var oNode = this.Node_Head;

			for(int i = 0; i < a_nIdx; ++i)
			{
				oNode = oNode.Node_Next;
			}

			return oNode;
		}
		private CNode CreateNode(T a_tVal)
		{
			return new CNode()
			{
				Val = a_tVal,
				Node_Next = null
			};
		}
	}
}
