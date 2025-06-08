using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02910000000001_EvenI.Algorithm.E01.Solution.Classes.Runtime.Solution_06
{
	/**
	 * 분리 집합
	 */
	class CS01Set_Disjoint_06<T> where T : IComparable
	{
		/**
		 * 노드
		 */
		public class CNode
		{
			public T Val { get; set; }
			public CNode Node_Parent { get; set; } = null;
		}

		public CNode Node_Root { get; private set; } = null;

		/** 루트 노드를 추가한다 */
		public void AddNode_Root(CNode a_oNode)
		{
			// 노드 추가가 불가능 할 경우
			if(this.Node_Root != null)
			{
				return;
			}

			this.Node_Root = a_oNode;
		}

		/** 집합을 합친다 */
		public void UnionSet_Disjoint(CS01Set_Disjoint_06<T> a_oSet)
		{
			// 집합 합치기가 불가능 할 경우
			if(this.Node_Root == null || a_oSet.Node_Root == null)
			{
				return;
			}

			var oNode_Root = CS01Set_Disjoint_06<T>.FindNode_Root(a_oSet.Node_Root);
			oNode_Root.Node_Parent = this.Node_Root;
		}

		/** 루트 노드를 탐색한다 */
		public static CNode FindNode_Root(CNode a_oNode)
		{
			// 노드 탐색이 불가능 할 경우
			if(a_oNode == null)
			{
				return null;
			}

			return (a_oNode.Node_Parent == null) ?
				a_oNode : CS01Set_Disjoint_06<T>.FindNode_Root(a_oNode.Node_Parent);
		}

		/** 노드를 생성한다 */
		public static CNode CreateNode(T a_tVal)
		{
			return new CNode()
			{
				Val = a_tVal
			};
		}
	}
}
