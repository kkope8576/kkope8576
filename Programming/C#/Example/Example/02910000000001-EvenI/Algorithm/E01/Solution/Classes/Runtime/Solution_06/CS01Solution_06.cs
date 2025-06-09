using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Example._02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_08;

namespace Example._02910000000001_EvenI.Algorithm.E01.Solution.Classes.Runtime.Solution_06
{
	/**
	 * Solution 4
	 */
	internal class CS01Solution_06
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
			var oRandom = new Random();
			var oGraph_List = new CE01Graph_AdjacencyList_08_01<char, int>();

			oGraph_List.AddVertex('A', oRandom.Next(1, 100));
			oGraph_List.AddVertex('B', oRandom.Next(1, 100));
			oGraph_List.AddVertex('C', oRandom.Next(1, 100));
			oGraph_List.AddVertex('D', oRandom.Next(1, 100));
			oGraph_List.AddVertex('E', oRandom.Next(1, 100));
			oGraph_List.AddVertex('F', oRandom.Next(1, 100));
			oGraph_List.AddVertex('G', oRandom.Next(1, 100));

			oGraph_List.AddEdge('A', 'B', 1);
			oGraph_List.AddEdge('A', 'D', 1);
			oGraph_List.AddEdge('A', 'C', 2);
			oGraph_List.AddEdge('A', 'E', 3);

			oGraph_List.AddEdge('B', 'A', 1);
			oGraph_List.AddEdge('B', 'C', 1);
			oGraph_List.AddEdge('B', 'G', 2);

			oGraph_List.AddEdge('C', 'B', 1);
			oGraph_List.AddEdge('C', 'D', 1);
			oGraph_List.AddEdge('C', 'A', 2);

			oGraph_List.AddEdge('D', 'A', 1);
			oGraph_List.AddEdge('D', 'C', 1);
			oGraph_List.AddEdge('D', 'E', 2);
			oGraph_List.AddEdge('D', 'G', 3);

			oGraph_List.AddEdge('E', 'F', 1);
			oGraph_List.AddEdge('E', 'D', 2);
			oGraph_List.AddEdge('E', 'A', 3);

			oGraph_List.AddEdge('F', 'E', 1);
			oGraph_List.AddEdge('F', 'G', 2);

			oGraph_List.AddEdge('G', 'B', 2);
			oGraph_List.AddEdge('G', 'F', 2);
			oGraph_List.AddEdge('G', 'D', 3);

			var oTree_MinCostSpanning = E01CreateTree_MinCostSpanning_08(oGraph_List);

			Console.WriteLine("=====> 최소 비용 신장 트리 - 크루스칼 <=====");
			S01PrintTree_MinCostSpanning_04(oTree_MinCostSpanning, 'A');
		}

		/** 최소 비용 신장 트리를 출력한다 */
		private static void S01PrintTree_MinCostSpanning_04(CE01Graph_AdjacencyList_08_01<char, int> a_oTree_MinCostSpanning,
			char a_chStart)
		{
			a_oTree_MinCostSpanning.Enumerate(CE01Graph_AdjacencyList_08_01<char, int>.EOrder.BREADTH_FIRST,
				a_chStart, (a_chKey, a_nVal) =>
			{
				var oListEdges = a_oTree_MinCostSpanning.GetEdges(a_chKey);

				for(int i = 0; i < oListEdges.NumValues; ++i)
				{
					Console.WriteLine("{0} -> {1} : {2}",
						a_chKey, oListEdges[i].m_tTo, oListEdges[i].m_nCost);
				}
			});
		}

		/** 최소 비용 신장 트리를 생성한다 */
		private static CE01Graph_AdjacencyList_08_01<char, int> E01CreateTree_MinCostSpanning_08(CE01Graph_AdjacencyList_08_01<char, int> a_oGraph_List)
		{
			var oPQueueEdges = new PriorityQueue<CE01Graph_AdjacencyList_08_01<char, int>.CEdge, int>();
			var oDictSets_Disjoint = new Dictionary<char, CS01Set_Disjoint_06<char>>();
			var oTree_MinCostSpanning = new CE01Graph_AdjacencyList_08_01<char, int>();

			for(int i = 0; i < a_oGraph_List.NumVertices; ++i)
			{
				var oSet = new CS01Set_Disjoint_06<char>();
				oSet.AddNode_Root(CS01Set_Disjoint_06<char>.CreateNode(a_oGraph_List.ListVertices[i].m_tKey));

				oDictSets_Disjoint.Add(a_oGraph_List.ListVertices[i].m_tKey,
					oSet);

				oTree_MinCostSpanning.AddVertex(a_oGraph_List.ListVertices[i].m_tKey,
					a_oGraph_List.ListVertices[i].m_tVal);

				var oListEdges = a_oGraph_List.GetEdges(a_oGraph_List.ListVertices[i].m_tKey);

				for(int j = 0; j < oListEdges.NumValues; ++j)
				{
					oPQueueEdges.Enqueue(oListEdges[j], oListEdges[j].m_nCost);
				}
			}

			while(oPQueueEdges.Count > 0)
			{
				var oEdge = oPQueueEdges.Dequeue();

				var oSet_FromDisjoint = oDictSets_Disjoint[oEdge.m_tFrom];
				var oSet_ToDisjoint = oDictSets_Disjoint[oEdge.m_tTo];

				// 간선 추가가 불가능 할 경우
				if(CS01Set_Disjoint_06<char>.FindNode_Root(oSet_FromDisjoint.Node_Root) ==
					CS01Set_Disjoint_06<char>.FindNode_Root(oSet_ToDisjoint.Node_Root))
				{
					continue;
				}

				oSet_FromDisjoint.UnionSet_Disjoint(oSet_ToDisjoint);

				oTree_MinCostSpanning.AddEdge(oEdge.m_tFrom, oEdge.m_tTo, oEdge.m_nCost);
				oTree_MinCostSpanning.AddEdge(oEdge.m_tTo, oEdge.m_tFrom, oEdge.m_nCost);
			}

			return oTree_MinCostSpanning;
		}
	}
}
