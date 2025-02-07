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
//#define EXAMPLE
#define PRACTICE
//#define SOLUTION

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
		 * 따라서 C# 의 메인 메서드는 반드시 특정 클래스 내부에 static 키워드로 명시가 
		 * 되어있어야한다.
		 * 
		 * 메인 메서드 (진입 메서드) 란?
		 * - C# 으로 제작 된 프로그램이 실행 될 때 가장 먼저 호출 (실행) 되는 메서드를 의미한다.
		 * (+ 즉, 가장 먼저 실행되기 때문에 진입 메서드라고도 불린다는 것을 알 수 있다.)
		 * 
		 * 메인 메서드는 운영체제에 의해서 호출되기 때문에 생략하는 것이 불가능하며 해당 메서드를
		 * 생략 할 경우 링크 에러가 발생한다. (+ 즉, 프로그램이 제작되지 않는다는 것을 의미한다.)
		 * 
		 * 또한 메인 메서드는 다른 메서드와 달리 중복이 불가능하다. (+ 즉, 일반적인 메서드는
		 * 서로 다른 영역 일 경우 동일한 이름의 메서드를 구현하는 것이 가능하다는 것을 알 수 있다.)
		 * 
		 * 따라서 메인 메서드는 C# 으로 제작 된 프로그램에서 유일해야하며 해당 메서드가
		 * 호출되었다는 것은 프로그램이 실행되었다는 것을 의미하며 해당 메서드가 종료되었다는 것은
		 * 프로그램이 종료되었다는 것을 의미한다. (+ 즉, 메인 메서드가 종료되면 프로그램도
		 * 종료된다는 것을 알 수 있다.)
		 */
		/** 메인 메서드 */
		public static void Main(string[] args)
		{
			Program.Main_Programming(args);
			//Program.Main_Structure(args);
			//Program.Main_Algorithm(args);
		}

		/*
		 * 프로그래밍 언어 과제 1
		 * - ABC 출력하기
		 * - 다양한 방법으로 ABC 출력 (+ 최소 4 가지 이상)
		 * 
		 * 프로그래밍 언어 과제 2
		 * - 학점 계산 프로그램 제작하기
		 * - 점수를 입력 받아 점수에 해당하는 학점을 출력
		 * - if ~ else 조건문 및 switch ~ case 조건문을 사용해서 각각 구현
		 * 
		 * 학점 계산 방법
		 * - A : 90 ~ 100
		 * - B : 80 ~ 89
		 * - C : 70 ~ 79
		 * - D : 60 ~ 69
		 * - F : 60 미만
		 * 
		 * 세부 학점 계산 방법
		 * - + : 7 ~ 9
		 * - 0 : 4 ~ 6
		 * - - : 0 ~ 3
		 * 
		 * Ex)
		 * 점수 입력 : 90
		 * 결과 : A-
		 * 
		 * 점수 입력 : 96
		 * 결과 : A0
		 * 
		 * 프로그래밍 언어 과제 3
		 * - 업 / 다운 게임 제작하기
		 * - 1 ~ 99 범위 숫자 중 하나를 랜덤하게 선택
		 * - 사용자로부터 숫자를 입력 받아 정답 여부 검사
		 * - 정답이 아닐 경우 숫자의 비교를 통해 힌트 출력
		 * 
		 * Ex)
		 * 정답 : 95
		 * 
		 * 숫자 입력 : 60
		 * 정답은 60 보다 큽니다.
		 * 
		 * 숫자 입력 : 99
		 * 정답은 99 보다 작습니다.
		 * 
		 * 숫자 입력 : 95
		 * 프로그램을 종료합니다.
		 * 
		 * 프로그래밍 언어 과제 4
		 * - 바위 / 가위 / 보 게임 제작하기
		 * - 사용자로부터 선택지를 입력 받은 후 컴퓨터의 선택과 비교
		 * - 컴퓨터에게 승리했을 경우 게임 유지
		 * - 컴퓨터에게 패배했을 경우 전적 출력 후 게임 종료
		 * 
		 * Ex)
		 * 숫자 (1. 바위, 2. 가위, 3. 보) 입력 : 1
		 * 결과 : 승리 (나 - 바위, 컴퓨터 - 가위)
		 * 
		 * 숫자 (1. 바위, 2. 가위, 3. 보) 입력 : 2
		 * 결과 : 무승부 (나 - 가위, 컴퓨터 - 가위)
		 * 
		 * 숫자 (1. 바위, 2. 가위, 3. 보) 입력 : 3
		 * 결과 : 패배 (나 - 보, 컴퓨터 - 가위)
		 * 
		 * 전적 : 1 승 1 무 1 패
		 * 프로그램을 종료합니다.
		 *
		 * 프로그래밍 언어 과제 5
		 * - 직각 삼각형 출력하기
		 * - 라인 수를 입력 받아 해당 라인만큼 직각 삼각형 출력
		 * - 출력되는 삼각형은 상 / 하 / 좌 / 우 가 반전 된 총 4 개의 직각 삼각형
		 * 
		 * Ex)
		 * 라인 수 입력 : 5
		 * *
		 * **
		 * ***
		 * ****
		 * *****
		 * 
		 * *****
		 * ****
		 * ***
		 * **
		 * *
		 * 
		 *     *
		 *    **
		 *   ***
		 *  ****
		 * *****
		 * 
		 * *****
		 *  ****
		 *   ***
		 *    **
		 *     *
		 *
		 * 프로그래밍 언어 과제 6
		 * - 경우의 수 출력하기
		 * - 서로 다른 가격의 3 개 제품이 존재 (Ex. 100 원, 250 원, 500 원)
		 * - 소지 금액을 입력 받아 해당 금액을 모두 소비해서 구입 할 수 있는 경우의 수 모두 출력
		 * 
		 * Ex)
		 * 소지 금액 입력 : 1000
		 * 100 원 제품 x 0 개, 250 원 제품 x 0 개, 500 원 제품 x 2 개
		 * 100 원 제품 x 0 개, 250 원 제품 x 2 개, 500 원 제품 x 1 개
		 * 100 원 제품 x 5 개, 250 원 제품 x 0 개, 500 원 제품 x 1 개
		 * 이하 생략...
		 *
		 * 프로그래밍 언어 과제 7
		 * - 2 차원 배열 달팽이 형태로 초기화하기
		 * - 2 차원 배열 크기를 입력 받은 후 해당 크기만큼 배열 초기화 (+ 단, 크기는 정방으로 입력)
		 * 
		 * Ex)
		 * 크기 입력 : 7
		 *  1  2  3  4  5  6  7
		 * 24 25 26 27 28 29  8
		 * 23 40 41 42 43 30  9
		 * 22 39 48 49 44 31 10
		 * 21 38 47 46 45 32 11
		 * 20 37 36 35 34 33 12
		 * 19 18 17 16 15 14 13
		 * 
		 * 프로그래밍 언어 과제 8
		 * - 2 차원 배열 직각 삼각형 형태로 초기화하기
		 * - 2 차원 배열 크기를 입력 받은 후 해당 크기만큼 배열 초기화 (+ 단, 크기는 정방으로 입력)
		 * 
		 * Ex)
		 * 크기 입력 : 7	
		 *  1  0  0  0  0  0  0 
		 * 18  2  0  0  0  0  0 
		 * 16 27 20  4  0  0  0 
		 * 15 26 28 21  5  0  0 
		 * 14 25 24 23 22  6  0 
		 * 13 12 11 10  9  8  7 
		 * 
		 * 프로그래밍 언어 과제 9
		 * - 행맨 게임 제작하기
		 * - 단어를 랜덤하게 선택 후 해당 단어의 문자를 입력
		 * - 입력 받은 문자가 단어에 존재 할 경우 해당 문자 활성화 (+ 단, 대/소문자 구분 X)
		 * - 문자를 모두 활성화했을 경우 게임 종료
		 * 
		 * Ex)
		 * 정답 : Microsoft
		 * 
		 * _ _ _ r _ _ _ f _
		 * 문자 입력 : m
		 * 
		 * M _ _ r _ _ _ f _
		 * 문자 입력 : o
		 * 
		 * M _ _ r o _ o f _
		 * 문자 입력 : f
		 * 
		 * 이하 생략...
		 *
		 * 프로그래밍 언어 과제 10
		 * - 야구 게임 제작하기
		 * - 1 ~ 9 범위 숫자 중 중복되지 않는 4 개 선택 (+ 단, 중복 X)
		 * - 4 개의 숫자를 사용자로부터 입력
		 * - 입력 받은 숫자가 정답에 존재하고 위치가 일치하면 스트라이크
		 * - 숫자가 정답에 존재하지만 위치가 일치하지 않으면 볼
		 * - 4 스트라이크가 되면 게임 종료
		 * 
		 * Ex)
		 * 정답 : 4 1 3 9
		 * 
		 * 숫자 입력 : 1 4 3 9
		 * 결과 : 2 Strike, 2 Ball
		 * 
		 * 숫자 입력 : 1 4 9 3
		 * 결과 : 0 Strike, 4 Ball
		 * 
		 * ..이하 생략
		 *
		 * 프로그래밍 언어 과제 11
		 * - 슬라이드 게임 제작하기
		 * - 2 차원 배열 크기를 입력 받은 후 해당 배열을 1 부터 차례대로 초기화 (+ 단, 공백 존재)
		 * - 초기화 된 배열을 무작위로 섞은 후 기존 순서대로 정렬시키면 게임 종료
		 * - 공백 주위 (상 / 하 / 좌 / 우) 를 입력하면 공백과 해당 위치에 숫자 교환
		 * - 잘못된 위치를 입력했을 경우 변화 X
		 * 
		 * Ex)
		 * 크기 (너비, 높이) 입력 : 5 5
		 * =====> 현재 상태 <=====
		 *  1  7  3  4  5
		 * 12  2  8  9 15
		 * 11  6 17 23 10
		 * 21 13 18    20
		 * 16 22 14 24 19
		 * 
		 * 위치 (X, Y) 입력 : 4 3
		 * 
		 * =====> 현재 상태 <=====
		 *  1  7  3  4  5
		 * 12  2  8  9 15
		 * 11  6 17    10
		 * 21 13 18 23 20
		 * 16 22 14 24 19
		 * 
		 * 위치 (X, Y) 입력 : 5 3
		 * 
		 * =====> 현재 상태 <=====
		 *  1  7  3  4  5
		 * 12  2  8  9 15
		 * 11  6 17 10   
		 * 21 13 18 23 20
		 * 16 22 14 24 19
		 * 
		 * 위치 (X, Y) 입력 : 5 5
		 * 
		 * ...이하 생략
		 */
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
			//_02910000000001_EvenI.Programming.E01.Example.Classes.Runtime.Example_16.CE01Example_16.Start(args);
#elif PRACTICE
            //_02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_01.CS01Practice_01.Start(args);
			//_02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_02.CS01Practice_02.Start(args);
			//_02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_03.CS01Practice_03.Start(args);
			//_02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_04.CS01Practice_04.Start(args);
			//_02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_05.CS01Practice_05.Start(args);
			_02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_06.CS01Practice_06.Start(args);
			//_02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_07.CS01Practice_07.Start(args);
			//_02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_08.CS01Practice_08.Start(args);
			//_02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_09.CS01Practice_09.Start(args);
			//_02910000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_10.CS01Practice_10.Start(args);

#elif SOLUTION
			//_02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_01.CS01Solution_01.Start(args);
			//_02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_02.CS01Solution_02.Start(args);
			//_02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_03.CS01Solution_03.Start(args);
			//_02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_04.CS01Solution_04.Start(args);
			//_02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_05.CS01Solution_05.Start(args);
			//_02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_06.CS01Solution_06.Start(args);
			//_02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_07.CS01Solution_07.Start(args);
			//_02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_08.CS01Solution_08.Start(args);
			//_02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_09.CS01Solution_09.Start(args);
			//_02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_10.CS01Solution_10.Start(args);
			//_02910000000001_EvenI.Programming.E01.Solution.Classes.Runtime.Solution_11.CS01Solution_11.Start(args);
#endif // #if EXAMPLE
		}

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
		/** 자료구조 메인 메서드 */
		private static void Main_Structure(string[] args)
		{
#if EXAMPLE
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_01.CE01Example_01.Start(args);
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_02.CE01Example_02.Start(args);
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_03.CE01Example_03.Start(args);
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_04.CE01Example_04.Start(args);
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_05.CE01Example_05.Start(args);
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_06.CE01Example_06.Start(args);
			//_02910000000001_EvenI.Structure.E01.Example.Classes.Runtime.Example_07.CE01Example_07.Start(args);
#elif PRACTICE
			//_02910000000001_EvenI.Structure.E01.Practice.Classes.Runtime.Practice_02.CP01Practice_02.Start(args);
#elif SOLUTION
			//_02910000000001_EvenI.Structure.E01.Solution.Classes.Runtime.Solution_01.CS01Solution_01.Start(args);
			//_02910000000001_EvenI.Structure.E01.Solution.Classes.Runtime.Solution_02.CS01Solution_02.Start(args);
			//_02910000000001_EvenI.Structure.E01.Solution.Classes.Runtime.Solution_03.CS01Solution_03.Start(args);
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
