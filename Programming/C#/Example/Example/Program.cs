/*
 * 자료구조 과제 1
 * - 단방향 연결 리스트 구현하기
 * 
 * 자료구조 과제 2
 * - 단방향 원형 연결 리스트 구현하기
 * 
 * 자료구조 과제 3
 * - 이진 탐색 트리 레벨 순회 구현하기
 * 
 * 자료구조 과제 4
 * - 1 번 인덱스부터 시작하는 우선 순위 큐 구현하기
 */

/*
 * 전처리기 명령어란?
 * - 전처리기 단계에서 실행되는 명령어로서 C# 코드로 작성 된 명령문을 컴파일하기 전에 코드를 한번 
 * 튜닝하는 역할을 수행한다.
 * 
 * 전처리기 명령어는 모두 # 으로 시작하는 특징이 존재하며 C# 의 기능이 아니기 때문에 C# 과는 전혀 
 * 다른 문법을 지니고 있다.
 * 
 * 또한 해당 단계는 전처리기에 의해서 처리 된다는 특징이 존재한다.
 * 
 * C# 주요 전처리기 명령어
 * - define
 * - if ~ else ~ endif
 * 
 * define 명령어는 특정 기호 (심볼) 를 정의하는 역할을 수행하며 해당 명령어로 정의 된 심볼을
 * 기반으로 조건문을 작성하면 특정 코드를 활성화하거나 비활성화하는 것이 가능하다.
 * 
 * Ex)
 * #if MOBILE_PLATFORM
 *      // 모바일 플랫폼 명령문
 * #else
 *      // 기타 플랫폼 명령문
 * #endif
 */
#define EXAMPLE
#define PRACTICE
#define SOLUTION

/*
 * 네임스페이스란?
 * - C# 으로 작성 된 명령문을 구분하는 단위를 의미한다. (즉, C# 은 C/C++ 과 달리 특정 파일에 
 * 존재하는 기능을 사용하기 위해서 해당 파일의 경로를 직접 명시하는 것이 아니라 네임스페이스 경로를 
 * 명시해야한다.)
 * 
 * 따라서 네임스페이스는 C# 에서 특정 기능을 포함하기 위한 논리적인 경로를 의미한다는 것을 알 수 
 * 있다.
 */
namespace Example
{
	internal class Program
	{
		/*
		 * C# 의 메서드는 C/C++ 과 달리 전역 영역에 구현하는 것이 불가능하며 항상 특정 클래스 or 
		 * 구조체 내부에서만 구현하는 것이 가능하다. 
		 * 
		 * 따라서 C# 의 메인 메서드 (진입 메서드) 는 반드시 특정 클래스 내부에 static 키워드로 
		 * 명시가 되어있어야한다.
		 */
		/** 메인 메서드 */
		public static void Main(string[] args)
		{
			//Program.Main_Programming(args);
			Program.Main_Structure(args);
			//Program.Main_Algorithm(args);
		}

		/** 프로그래밍 메인 메서드 */
		private static void Main_Programming(string[] args)
		{
			/*
			 * C# 은 . (맴버 접근 연산자) 를 통해 특정 네임 스페이스나 클래스 하위에 접근하는 것이 
			 * 가능하다. (즉, 해당 연산자를 활용하면 특정 클래스 내부에 존재하는 메서드를 호출하는 
			 * 것이 가능하다.)
			 * 
			 * 메서드 (함수) 란?
			 * - 특정 명령문을 포함하고 있는 기능을 의미한다. (즉, 메서드를 실행하면 메서드 내부에 
			 * 존재하는 명령문이 동작한다는 것을 알 수 있다.)
			 * 
			 * 따라서 메서드를 활용하면 여러 기능들을 미리 만들어서 재사용하는 것이 가능하다.
			 */
#if EXAMPLE
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_01.CE01Example_01.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_02.CE01Example_02.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_03.CE01Example_03.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_04.CE01Example_04.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_05.CE01Example_05.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_06.CE01Example_06.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_07.CE01Example_07.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_08.CE01Example_08.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_09.CE01Example_09.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_10.CE01Example_10.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_11.CE01Example_11.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_12.CE01Example_12.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_13.CE01Example_13.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_14.CE01Example_14.Start(args);
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_15.CE01Example_15.Start(args);
			_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_16.CE01Example_16.Start(args);
#endif // #if EXAMPLE
		}

		/** 자료구조 메인 메서드 */
		private static void Main_Structure(string[] args)
		{
#if EXAMPLE
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_01.CE01Example_01.Start(args);
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_02.CE01Example_02.Start(args);
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_03.CE01Example_03.Start(args);
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_04.CE01Example_04.Start(args);
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_05.CE01Example_05.Start(args);
			_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_06.CE01Example_06.Start(args);
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_07.CE01Example_07.Start(args);
#elif PRACTICE
			_02910000000001_EvenI.Structure.E01.Practice.Classes.Runtime.Practice_02.CP01Practice_02.Start(args);
#elif SOLUTION
			//_02910000000001_EvenI.Structure.E01.Solution.Classes.Runtime.Solution_01.CS01Solution_01.Start(args);
			//_02910000000001_EvenI.Structure.E01.Solution.Classes.Runtime.Solution_02.CS01Solution_02.Start(args);
			_02910000000001_EvenI.Structure.E01.Solution.Classes.Runtime.Solution_03.CS01Solution_03.Start(args);
#endif // #if EXAMPLE
		}

		/** 알고리즘 메인 메서드 */
		private static void Main_Algorithm(string[] args)
		{
#if EXAMPLE
			_02910000000001_EvenI.Algorithm.E01.Example.Classes.Runtime.Example_01.CE01Example_01.Start(args);
			//_02910000000001_EvenI.Algorithm.E01.Example.Classes.Runtime.Example_02.CE01Example_02.Start(args);
			//_02910000000001_EvenI.Algorithm.E01.Example.Classes.Runtime.Example_03.CE01Example_03.Start(args);
			//_02910000000001_EvenI.Algorithm.E01.Example.Classes.Runtime.Example_04.CE01Example_04.Start(args);
			//_02910000000001_EvenI.Algorithm.E01.Example.Classes.Runtime.Example_05.CE01Example_05.Start(args);
			//_02910000000001_EvenI.Algorithm.E01.Example.Classes.Runtime.Example_06.CE01Example_06.Start(args);
			//_02910000000001_EvenI.Algorithm.E01.Example.Classes.Runtime.Example_07.CE01Example_07.Start(args);
			//_02910000000001_EvenI.Algorithm.E01.Example.Classes.Runtime.Example_08.CE01Example_08.Start(args);
#endif // #if EXAMPLE
		}
	}
}
