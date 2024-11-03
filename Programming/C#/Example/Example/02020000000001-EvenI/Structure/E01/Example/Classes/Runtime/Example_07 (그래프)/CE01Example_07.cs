#define S_EXAMPLE_E01_EXAMPLE_07_01
#define S_EXAMPLE_E01_EXAMPLE_07_02

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 그래프 (Graph) 란?
 * - 정점과 정점을 연결하는 간선을 통해 데이터 간에 관계를 표현 할 수 있는 자료구조를 의미한다. (즉,
 * 그래프를 활용하면 데이터 간에 복잡한 관계도 표현하는 것이 가능하다.)
 * 
 * 그래프는 간선의 표현 방식에 따라 방향성 그래프와 무방향성 그래프로 구분된다. (즉, 방향성 그래프는
 * 간선에 방향이 존재하기 때문에 정점이 연결되어있더라도 방향에 따라 이동이 불가능 할 수 있다는 것을
 * 알 수 있다.)
 * 
 * 그래프는 정점의 관계를 나타내는 간선을 표현하는 방법에 따라 행렬 기반 그래프와 리스트 기반 
 * 그래프로 나뉜다. (즉, 행렬 기반을 간선을 2 차원 배열을 통해 표현하고 리스트 기반 그래프는
 * 리스트로 간선을 표현한다는 것을 알 수 잇다.)
 * 
 * 행렬 기반 그래프 vs 리스트 기반 그래프
 * - 행렬 기반 그래프는 정점 개수가 늘어나는만큼 2 차원 배열의 크기도 같이 커지기 때문에 간선이
 * 경우 불필요한 메모리가 낭비되는 단점이 존재한다. (즉, 간선이 개수가 많아질수록 행렬 기반 그래프가
 * 효율적이라는 것을 알 수 있다.)
 * 
 * 반면 리스트 기반 그래프는 정점 개수가 늘어난다고 하더라도 간선을 표현하는 리스트는 늘어나지 않기
 * 때문에 정점이 많고 간선의 개수가 작을 경우 메모리를 효율적으로 사용하는 장점이 존재한다. (단,
 * 간선의 개수가 많아질수록 효율성이 떨어지는 단점이 존재한다.)
 */
namespace Example._02020000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_07
{
	/**
	 * Example 7
	 */
	internal class CE01Example_07
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if S_EXAMPLE_E01_EXAMPLE_07_01
			var oRandom = new Random();
			var oGraphMatrix = new CE01Graph_AdjacencyMatrix_07<char, int>();

			oGraphMatrix.AddVertex('A', oRandom.Next(1, 100));
			oGraphMatrix.AddVertex('B', oRandom.Next(1, 100));
			oGraphMatrix.AddVertex('C', oRandom.Next(1, 100));
			oGraphMatrix.AddVertex('D', oRandom.Next(1, 100));
			oGraphMatrix.AddVertex('E', oRandom.Next(1, 100));
			oGraphMatrix.AddVertex('F', oRandom.Next(1, 100));
			oGraphMatrix.AddVertex('G', oRandom.Next(1, 100));

			oGraphMatrix.AddEdge('A', 'B');
			oGraphMatrix.AddEdge('A', 'C');
			oGraphMatrix.AddEdge('A', 'E');

			oGraphMatrix.AddEdge('B', 'C');
			oGraphMatrix.AddEdge('B', 'G');

			oGraphMatrix.AddEdge('C', 'D');

			oGraphMatrix.AddEdge('D', 'A');
			oGraphMatrix.AddEdge('D', 'E');

			oGraphMatrix.AddEdge('E', 'F');
			oGraphMatrix.AddEdge('F', 'G');
			oGraphMatrix.AddEdge('G', 'A');

			Console.WriteLine("=====> 그래프 요소 <=====");

			oGraphMatrix.Enumerate(CE01Graph_AdjacencyMatrix_07<char, int>.EOrder.DEPTH_FIRST, 'A', (a_chKey, a_nVal) =>
			{
				Console.Write("{0}, ", a_chKey);
			});

			oGraphMatrix.RemoveEdge('A', 'B');
			Console.WriteLine("\n\n=====> 그래프 요소 - 간선 제거 후 <=====");

			oGraphMatrix.Enumerate(CE01Graph_AdjacencyMatrix_07<char, int>.EOrder.DEPTH_FIRST, 'A', (a_chKey, a_nVal) =>
			{
				Console.Write("{0}, ", a_chKey);
			});

			oGraphMatrix.RemoveVertex('C');
			Console.WriteLine("\n\n=====> 그래프 요소 - 정점 제거 후 <=====");

			oGraphMatrix.Enumerate(CE01Graph_AdjacencyMatrix_07<char, int>.EOrder.DEPTH_FIRST, 'A', (a_chKey, a_nVal) =>
			{
				Console.Write("{0}, ", a_chKey);
			});

			Console.WriteLine();
#elif S_EXAMPLE_E01_EXAMPLE_07_02
			var oRandom = new Random();
			var oGraphList = new CE01Graph_AdjacencyList_07<char, int>();

			oGraphList.AddVertex('A', oRandom.Next(1, 100));
			oGraphList.AddVertex('B', oRandom.Next(1, 100));
			oGraphList.AddVertex('C', oRandom.Next(1, 100));
			oGraphList.AddVertex('D', oRandom.Next(1, 100));
			oGraphList.AddVertex('E', oRandom.Next(1, 100));
			oGraphList.AddVertex('F', oRandom.Next(1, 100));
			oGraphList.AddVertex('G', oRandom.Next(1, 100));

			oGraphList.AddEdge('A', 'B');
			oGraphList.AddEdge('A', 'C');
			oGraphList.AddEdge('A', 'E');

			oGraphList.AddEdge('B', 'C');
			oGraphList.AddEdge('B', 'G');

			oGraphList.AddEdge('C', 'D');

			oGraphList.AddEdge('D', 'A');
			oGraphList.AddEdge('D', 'E');

			oGraphList.AddEdge('E', 'F');
			oGraphList.AddEdge('F', 'G');
			oGraphList.AddEdge('G', 'A');

			Console.WriteLine("=====> 그래프 요소 <=====");

			oGraphList.Enumerate(CE01Graph_AdjacencyList_07<char, int>.EOrder.DEPTH_FIRST, 'A', (a_chKey, a_nVal) =>
			{
				Console.Write("{0}, ", a_chKey);
			});

			oGraphList.RemoveEdge('A', 'B');
			Console.WriteLine("\n\n=====> 그래프 요소 - 간선 제거 후 <=====");

			oGraphList.Enumerate(CE01Graph_AdjacencyList_07<char, int>.EOrder.DEPTH_FIRST, 'A', (a_chKey, a_nVal) =>
			{
				Console.Write("{0}, ", a_chKey);
			});

			oGraphList.RemoveVertex('C');
			Console.WriteLine("\n\n=====> 그래프 요소 - 정점 제거 후 <=====");

			oGraphList.Enumerate(CE01Graph_AdjacencyList_07<char, int>.EOrder.DEPTH_FIRST, 'A', (a_chKey, a_nVal) =>
			{
				Console.Write("{0}, ", a_chKey);
			});

			Console.WriteLine();
#endif // #if S_EXAMPLE_E01_EXAMPLE_07_01
		}
	}
}
