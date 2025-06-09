using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example._02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_08;

namespace Example._02910000000001_EvenI.Algorithm.E01.Practice.Classes.Runtime.Practice_06
{
	internal class CP01Practice_06
	{
		public static void Start(string[] args)
		{
			var oRandom = new Random();
			var oGraph_Matrix = new CE01Graph_AdjacencyMatrix_08_02<char, int>();

			oGraph_Matrix.AddVertex('A', oRandom.Next(1, 100));
			oGraph_Matrix.AddVertex('B', oRandom.Next(1, 100));
			oGraph_Matrix.AddVertex('C', oRandom.Next(1, 100));
			oGraph_Matrix.AddVertex('D', oRandom.Next(1, 100));
			oGraph_Matrix.AddVertex('E', oRandom.Next(1, 100));
			oGraph_Matrix.AddVertex('F', oRandom.Next(1, 100));
			oGraph_Matrix.AddVertex('G', oRandom.Next(1, 100));

			oGraph_Matrix.AddEdge('A', 'B', 1);
			oGraph_Matrix.AddEdge('A', 'D', 1);
			oGraph_Matrix.AddEdge('A', 'C', 2);
			oGraph_Matrix.AddEdge('A', 'E', 3);

			oGraph_Matrix.AddEdge('B', 'A', 1);
			oGraph_Matrix.AddEdge('B', 'C', 1);
			oGraph_Matrix.AddEdge('B', 'G', 2);

			oGraph_Matrix.AddEdge('C', 'B', 1);
			oGraph_Matrix.AddEdge('C', 'D', 1);
			oGraph_Matrix.AddEdge('C', 'A', 2);

			oGraph_Matrix.AddEdge('D', 'A', 1);
			oGraph_Matrix.AddEdge('D', 'C', 1);
			oGraph_Matrix.AddEdge('D', 'E', 2);
			oGraph_Matrix.AddEdge('D', 'G', 3);

			oGraph_Matrix.AddEdge('E', 'F', 1);
			oGraph_Matrix.AddEdge('E', 'D', 2);
			oGraph_Matrix.AddEdge('E', 'A', 3);

			oGraph_Matrix.AddEdge('F', 'E', 1);
			oGraph_Matrix.AddEdge('F', 'G', 2);

			oGraph_Matrix.AddEdge('G', 'B', 2);
			oGraph_Matrix.AddEdge('G', 'F', 2);
			oGraph_Matrix.AddEdge('G', 'D', 3);

			var oTree_MinCostSpanning = CreateTree_MinCostSpanning_asending(oGraph_Matrix);

			Console.WriteLine("=====> 최소 비용 신장 트리 - 크루스칼 <=====");
			PrintTree_MinCostSpanning_08(oTree_MinCostSpanning, 'A');
		}

		private static void PrintTree_MinCostSpanning_08(CE01Graph_AdjacencyMatrix_08_02<char, int> a_oTree_MinCostSpanning,
			char a_chStart)
		{
			a_oTree_MinCostSpanning.Enumerate(CE01Graph_AdjacencyMatrix_08_02<char, int>.EOrder.BREADTH_FIRST,
				a_chStart, (a_chKey, a_nVal) =>
				{
					var oListEdges = a_oTree_MinCostSpanning.GetEdges(a_chKey);

					for(int i = 0; i < oListEdges.NumValues; ++i)
					{
						Console.WriteLine("{0} -> {1} : {2}",
							a_chKey, oListEdges[i], a_oTree_MinCostSpanning.GetCost(a_chKey, oListEdges[i]));
					}
				});
		}

		private struct STE01Info_Edge_08
		{
			public char m_chFrom;
			public char m_chTo;
			public int m_nCost;
		}

		
		private static STE01Info_Edge_08 E01MakeInfo_Edge_08(char a_chFrom,
			char a_chTo, int a_nCost)
		{
			return new STE01Info_Edge_08()
			{
				m_chFrom = a_chFrom,
				m_chTo = a_chTo,

				m_nCost = a_nCost
			};
		}

		private static bool E01IsConnect_Vertex_08(CE01Graph_AdjacencyMatrix_08_02<char, int> a_oTree_MinCostSpanning,
			char a_chFrom, char a_chTo)
		{
			bool bIsConnect = false;

			a_oTree_MinCostSpanning.Enumerate(CE01Graph_AdjacencyMatrix_08_02<char, int>.EOrder.BREADTH_FIRST,
				a_chFrom, (a_chKey, a_nVal) =>
				{
					bIsConnect = bIsConnect || a_chTo == a_chKey;
				});

			return bIsConnect;
		}

		private static CE01Graph_AdjacencyMatrix_08_02<char, int> CreateTree_MinCostSpanning_asending(CE01Graph_AdjacencyMatrix_08_02<char, int> a_oGraph_Matrix)
		{
			var oTree_MinCostSpanning = new CE01Graph_AdjacencyMatrix_08_02<char, int>();

			for(int i = 0; i < a_oGraph_Matrix.NumVertices; ++i)
			{
				oTree_MinCostSpanning.AddVertex(a_oGraph_Matrix.ListVertices[i].m_tKey, 0);
			}

			var oPQueueInfos_Edge = new PriorityQueue<STE01Info_Edge_08, int>();

			for(int i = 0; i < a_oGraph_Matrix.NumVertices; ++i)
			{
				var oListEdges = a_oGraph_Matrix.GetEdges(a_oGraph_Matrix.ListVertices[i].m_tKey);

				for(int j = 0; j < oListEdges.NumValues; ++j)
				{
					var stInfo_Edge = E01MakeInfo_Edge_08(a_oGraph_Matrix.ListVertices[i].m_tKey,
						oListEdges[j], a_oGraph_Matrix.GetCost(a_oGraph_Matrix.ListVertices[i].m_tKey, oListEdges[j]));

					oPQueueInfos_Edge.Enqueue(stInfo_Edge, stInfo_Edge.m_nCost);
				}
			}
			while(oPQueueInfos_Edge.Count > 0)
			{
				var stInfo_Edge = oPQueueInfos_Edge.Dequeue();

				if(E01IsConnect_Vertex_08(oTree_MinCostSpanning, stInfo_Edge.m_chFrom, stInfo_Edge.m_chTo))
				{
					continue;
				}
				oTree_MinCostSpanning.AddEdge(stInfo_Edge.m_chFrom, stInfo_Edge.m_chTo, stInfo_Edge.m_nCost);

			}
			return oTree_MinCostSpanning;
		}
	}
}

