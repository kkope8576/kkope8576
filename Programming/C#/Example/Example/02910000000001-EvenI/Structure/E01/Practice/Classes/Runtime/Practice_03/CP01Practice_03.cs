using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Structure.E01.Practice.Classes.Runtime.Practice_03
{
	internal class CP01Practice_03<T> where T : IComparable
	{
		public class CNode
		{
			public T Val { get; set; }
			public CNode Node_LChild { get; set; } = null;
			public CNode Node_RChild { get; set; } = null;
		}
		public CNode Node_Root { get; private set; } = null;

		public void AddVal(T a_tVal)
		{
			var oNode = this.CreateNode(a_tVal);

			if(this.Node_Root == null)
			{
				this.Node_Root = oNode;
				return;
			}
			var oNode_Child = this.Node_Root;
			CNode oNode_Parent = null;

			while(oNode_Child != null)
			{
				oNode_Parent = oNode_Child;

				if(a_tVal.CompareTo(oNode_Child.Val) < 0)
				{
					oNode_Child = oNode_Child.Node_LChild;
				}

				else
				{
					oNode_Child = oNode_Child.Node_RChild;
				}
			}

			if(a_tVal.CompareTo(oNode_Parent.Val) < 0)
			{
				oNode_Parent.Node_LChild = oNode;
			}
			else
			{
				oNode_Parent.Node_RChild = oNode;
			}
		}

		public void RemoveVal(T a_tVal)
		{
			var oNode_Remove = this.Node_Root;
			CNode oNode_Parent = null;

			while(oNode_Remove != null && a_tVal.CompareTo(oNode_Remove.Val) != 0)
			{
				oNode_Parent = oNode_Remove;

				if(a_tVal.CompareTo(oNode_Remove.Val) < 0)
				{
					oNode_Remove = oNode_Remove.Node_LChild;
				}
				else
				{
					oNode_Remove = oNode_Remove.Node_RChild;
				}
			}
			if(oNode_Remove == null)
			{
				return;
			}
			if(oNode_Remove.Node_LChild != null && oNode_Remove.Node_RChild != null)
			{
				oNode_Parent = oNode_Remove;
				var oNode_Descendants = oNode_Remove.Node_RChild;

				while(oNode_Descendants.Node_LChild != null)
				{
					oNode_Parent = oNode_Descendants;
					oNode_Descendants = oNode_Descendants.Node_LChild;
				}

				oNode_Remove.Val = oNode_Descendants.Val;
				oNode_Remove = oNode_Descendants;
			}
			if(oNode_Remove == this.Node_Root)
			{
				this.Node_Root = (this.Node_Root.Node_LChild != null) ?
					this.Node_Root.Node_LChild : this.Node_Root.Node_RChild;
				return;
			}
			if(oNode_Remove.Node_LChild != null)
			{
				if(oNode_Remove == oNode_Parent.Node_LChild)
				{
					oNode_Parent.Node_LChild = oNode_Remove.Node_LChild;
				}
				else
				{
					oNode_Parent.Node_RChild = oNode_Remove.Node_LChild;
				}
			}

		}
		private void Enumerate_ByLevelOrder(CNode a_oNode, Action<T> a_oCallback)
		{
			var oQueueNodes = new Queue<CNode>();
			oQueueNodes.Enqueue(a_oNode);

			while(oQueueNodes.Count > 0)
			{
				var oNode = oQueueNodes.Dequeue();
				a_oCallback?.Invoke(oNode.Val);

				// 왼쪽 노드가 존재 할 경우
				if(oNode.Node_LChild != null)
				{
					oQueueNodes.Enqueue(oNode.Node_LChild);
				}

				// 오른쪽 노드가 존재 할 경우
				if(oNode.Node_RChild != null)
				{
					oQueueNodes.Enqueue(oNode.Node_RChild);
				}
			}
		}
		private CNode CreateNode(T a_tVal)
		{
			return new CNode()
			{
				Val = a_tVal
			};
		}
	}
}
