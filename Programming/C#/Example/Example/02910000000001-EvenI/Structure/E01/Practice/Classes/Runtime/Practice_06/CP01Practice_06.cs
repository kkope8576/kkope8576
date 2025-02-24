using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example._02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_02;
using Example._02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_03;
using Example._02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_04;


namespace Example._02910000000001_EvenI.Structure.E01.Practice.Classes.Runtime.Practice_06
{
	internal class CP01Practice_06<TKey, TVal> where TKey : IComparable where TVal : IComparable
	{
		public class CVertex : IComparable
		{
			public TKey m_tKey;
			public TVal m_tVal;

			public CE01List_Array_02_01<CEdge> m_oListEdges = new CE01List_Array_02_01<CEdge>();

			public int CompareTo(object? a_oObj)
			{
				var oVertex = a_oObj as CVertex;

				if(oVertex == null)
				{
					return -1;
				}

				int nCompare_Key = m_tKey.CompareTo(oVertex.m_tKey);
				int nCompare_Val = m_tVal.CompareTo(oVertex.m_tVal);

				return (nCompare_Key == 0 && nCompare_Val == 0) ? 0 : -1;
			}
		}
		public class CEdge : IComparable
		{
			public int m_nCost;

			public TKey m_tFrom;
			public TKey m_tTo;

			public int CompareTo(object? a_oObj)
			{
				var oEdge = a_oObj as CEdge;

				if(oEdge == null)
				{
					return -1;
				}

				int nCompare_From = m_tFrom.CompareTo(oEdge.m_tFrom);
				int nCompare_To = m_tTo.CompareTo(oEdge.m_tTo);

				return (nCompare_From == 0 && nCompare_To == 0) ? 0 : -1;
			}
		}
		public CE01List_Array_02_01<CVertex> ListVertices { get; private set; } = null;
		public int NumVertices => this.ListVertices.NumValues;

		public CP01Practice_06(int a_nSize = 5)
		{
			this.ListVertices = new CE01List_Array_02_01<CVertex>(a_nSize);
		}
		public CE01List_Array_02_01<CEdge> GetEdges(TKey a_tKey)
		{
			var oVertex = this.FindVertex(a_tKey);
			return (oVertex != null) ? oVertex.m_oListEdges : null;
		}
		public void AddVertex(TKey a_tKey, TVal a_tVal)
		{
			var oVertex = this.FindVertex(a_tKey);

			if(oVertex != null)
			{
				return;
			}

			oVertex = this.CreateVertex(a_tKey, a_tVal);
			this.ListVertices.AddVal(oVertex);
		}
		public void AddEdge(TKey a_tFrom, TKey a_tTo, int a_nCost)
		{
			var oVertex = this.FindVertex(a_tFrom);
			var oEdge = this.FindEdge(a_tFrom, a_tTo);

			if(oVertex == null || oEdge != null || a_tFrom.CompareTo(a_tTo) == 0)
			{
				return;
			}

			oEdge = this.CreateEdge(a_tFrom, a_tTo, a_nCost);
			oVertex.m_oListEdges.AddVal(oEdge);
		}
		public void RemoveVertex(TKey a_tKey)
		{
			var oVertex = this.FindVertex(a_tKey);

			if(oVertex == null)
			{
				return;
			}

			for(int i = 0; i < this.ListVertices.NumValues; ++i)
			{
				this.RemoveEdge(this.ListVertices[i].m_tKey, a_tKey);
			}

			this.ListVertices.RemoveVal(oVertex);
		}
		public void RemoveEdge(TKey a_tFrom, TKey a_tTo)
		{
			var oVertex = this.FindVertex(a_tFrom);
			var oEdge = this.FindEdge(a_tFrom, a_tTo);

			if(oVertex == null || oEdge == null || a_tFrom.CompareTo(a_tTo) == 0)
			{
				return;
			}

			oVertex.m_oListEdges.RemoveVal(oEdge);
		}
		public void Enumerate(TKey a_tKey_Start, Action<TKey, TVal> a_oCallback)
		{
			var oVertex = this.FindVertex(a_tKey_Start);

			if(oVertex == null)
			{
				return;
			}

			var oListKeys_Visit = new List<TKey>();
		}
		public CVertex FindVertex(TKey a_tKey)
		{
			for(int i = 0; i < this.ListVertices.NumValues; ++i)
			{
				if(a_tKey.CompareTo(this.ListVertices[i].m_tKey) == 0)
				{
					return this.ListVertices[i];
				}
			}

			return null;
		}
		public CEdge FindEdge(TKey a_tFrom, TKey a_tTo)
		{
			var oVertex = this.FindVertex(a_tFrom);

			if(oVertex == null)
			{
				return null;
			}

			for(int i = 0; i < oVertex.m_oListEdges.NumValues; ++i)
			{
				if(a_tTo.CompareTo(oVertex.m_oListEdges[i].m_tTo) == 0)
				{
					return oVertex.m_oListEdges[i];
				}
			}

			return null;
		}

		public void EnumerateByOrder_DepthFirst(TKey a_tKey,
			Action<TKey, TVal> a_oCallback, List<TKey> a_oOutListKeys_Visit)
		{
			var oStack = new CE01Stack_03<TKey>();
			oStack.Push(a_tKey);

			while(oStack.NumValues > 0)
			{
				var tKey = oStack.Pop();
				var oVertex = this.FindVertex(tKey);


				if(!a_oOutListKeys_Visit.Contains(tKey))
				{

					a_oCallback?.Invoke(oVertex.m_tKey, oVertex.m_tVal);
				}

				a_oOutListKeys_Visit.Add(oVertex.m_tKey);

				for(int i = 0; i < oVertex.m_oListEdges.NumValues; ++i)
				{
					if(a_oOutListKeys_Visit.Contains(oVertex.m_oListEdges[i].m_tTo))
					{
						continue;
					}

					oStack.Push(oVertex.m_oListEdges[i].m_tTo);
				}
			}
		}
		public CVertex CreateVertex(TKey a_tKey, TVal a_tVal)
		{
			return new CVertex()
			{
				m_tKey = a_tKey,
				m_tVal = a_tVal
			};
		}
		public CEdge CreateEdge(TKey a_tFrom, TKey a_tTo, int a_nCost)
		{
			return new CEdge()
			{
				m_nCost = a_nCost,

				m_tFrom = a_tFrom,
				m_tTo = a_tTo
			};
		}
	}
}
