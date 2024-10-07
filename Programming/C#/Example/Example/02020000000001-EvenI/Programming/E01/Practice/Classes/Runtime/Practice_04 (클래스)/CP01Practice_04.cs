#define P_PRACTICE_P01_PRACTICE_04_01
#define P_PRACTICE_P01_PRACTICE_04_02
#define P_PRACTICE_P01_PRACTICE_04_03

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example._02020000000001_EvenI.Programming.E01.Practice.Classes.Runtime.Practice_04
{
	/**
	 * Practice 4
	 */
	internal class CP01Practice_04
	{
		/** 초기화 */
		public static void Start(string[] args)
		{
#if P_PRACTICE_P01_PRACTICE_04_01
			CP01Character_04 oPlayer = new CP01Character_04(100, 10);
			CP01Character_04 oMonster = new CP01Character_04(100, 5);

			Console.WriteLine("=====> 공격 전 <=====");
			P01ShowInfo_04(oPlayer, oMonster);

			while(true)
			{
				oPlayer.Attack(oMonster);

				Console.WriteLine("\n=====> 플레이어 공격 후 <=====");
				P01ShowInfo_04(oPlayer, oMonster);

				Thread.Sleep(500);

				// 진행이 불가능 할 경우
				if(oPlayer.HP <= 0 || oMonster.HP <= 0)
				{
					break;
				}

				oMonster.Attack(oPlayer);

				Console.WriteLine("\n=====> 몬스터 공격 후 <=====");
				P01ShowInfo_04(oPlayer, oMonster);

				Thread.Sleep(500);

				// 진행이 불가능 할 경우
				if(oPlayer.HP <= 0 || oMonster.HP <= 0)
				{
					break;
				}
			}

			Console.WriteLine("\n{0} 가 이겼습니다.", 
				(oPlayer.HP > 0) ? "플레이어" : "몬스터");
#elif P_PRACTICE_P01_PRACTICE_04_02
			var oManager_Member = new CP01Manager_Member_04();
			var eMenu_Sel = EP01Menu_04.NONE;

			do
			{
				P01ShowMenu_04();

				Console.Write("\n선택 : ");
				int.TryParse(Console.ReadLine(), out int nMenu_Sel);

				eMenu_Sel = (EP01Menu_04)(nMenu_Sel - 1);

				switch(eMenu_Sel)
				{
					case EP01Menu_04.ADD_MEMBER: 
						P01AddMember_04(oManager_Member); 
						break;

					case EP01Menu_04.REMOVE_MEMBER:
						P01RemoveMember_04(oManager_Member);
						break;

					case EP01Menu_04.SEARCH_MEMBER:
						P01SearchMember_04(oManager_Member);
						break;

					case EP01Menu_04.SHOW_INFOS_MEMBER:
						P01ShowInfos_Member_04(oManager_Member);
						break;
				}

				Console.WriteLine();
			} while(eMenu_Sel != EP01Menu_04.EXIT);
#elif P_PRACTICE_P01_PRACTICE_04_03
			var oCanvas = new CP01Canvas_04();
			var eMenu_Sel = EP01Menu_04.NONE;

			do
			{
				P01ShowMenu_04();

				Console.Write("\n선택 : ");
				int.TryParse(Console.ReadLine(), out int nMenu_Sel);

				eMenu_Sel = (EP01Menu_04)(nMenu_Sel - 1);

				switch(eMenu_Sel)
				{
					case EP01Menu_04.ADD_LINE:
					case EP01Menu_04.ADD_TRIANGLE:
					case EP01Menu_04.ADD_RECTANGLE:
						var oShape = P01CreateShape_04(eMenu_Sel);
						oCanvas.AddShape(oShape);

						break;

					case EP01Menu_04.DRAW_SHAPES:
						oCanvas.DrawShapes();
						break;
				}

				Console.WriteLine();
			} while(eMenu_Sel != EP01Menu_04.EXIT);
#endif // #if P_PRACTICE_P01_PRACTICE_04_01
		}

#if P_PRACTICE_P01_PRACTICE_04_01
		/**
		 * 캐릭터
		 */
		private class CP01Character_04
		{
			public int HP { get; private set; } = 0;
			public int ATK { get; private set; } = 0;

			/** 생성자 */
			public CP01Character_04(int a_nHP, int a_nATK)
			{
				this.HP = a_nHP;
				this.ATK = a_nATK;
			}

			/** 공격한다 */
			public void Attack(CP01Character_04 a_oTarget)
			{
				a_oTarget.SetHP(a_oTarget.HP - this.ATK);
			}

			/** 체력을 변경한다 */
			public void SetHP(int a_nHP)
			{
				this.HP = Math.Max(a_nHP, 0);
			}
		}

		/** 정보를 출력한다 */
		private static void P01ShowInfo_04(CP01Character_04 a_oPlayer, 
			CP01Character_04 a_oMonster)
		{
			Console.WriteLine("플레이어 : {0}", a_oPlayer.HP);
			Console.WriteLine("몬스터 : {0}", a_oMonster.HP);
		}
#elif P_PRACTICE_P01_PRACTICE_04_02
		/**
		 * 메뉴
		 */
		private enum EP01Menu_04
		{
			NONE = -1,
			ADD_MEMBER,
			REMOVE_MEMBER,
			SEARCH_MEMBER,
			SHOW_INFOS_MEMBER,
			EXIT,
			MAX_VAL
		}

		/**
		 * 회원
		 */
		private class CP01Member_04
		{
			public string Name { get; private set; } = string.Empty;
			public string Number_Phone { get; private set; } = string.Empty;

			/** 생성자 */
			public CP01Member_04(string a_oName, string a_oNumber_Phone)
			{
				this.Name = a_oName;
				this.Number_Phone = a_oNumber_Phone;
			}

			/** 정보를 출력한다 */
			public void ShowInfo()
			{
				Console.WriteLine("이름 : {0}", this.Name);
				Console.WriteLine("전화번호 : {0}", this.Number_Phone);
			}
		}

		/**
		 * 회원 관리자
		 */
		private class CP01Manager_Member_04
		{
			public List<CP01Member_04> ListMembers { get; private set; } = new List<CP01Member_04>();

			/** 회원을 추가한다 */
			public void AddMember(string a_oName, string a_oNumber_Phone)
			{
				int nResult = this.FindMember(a_oName);

				// 회원이 없을 경우
				if(nResult < 0)
				{
					var oMember = new CP01Member_04(a_oName, a_oNumber_Phone);
					this.ListMembers.Add(oMember);
				}
				else
				{
					Console.WriteLine("{0} 회원이 이미 존재합니다.", a_oName);
				}
			}

			/** 회원을 제거한다 */
			public void RemoveMember(string a_oName)
			{
				int nResult = this.FindMember(a_oName);

				// 회원이 존재 할 경우
				if(nResult >= 0)
				{
					this.ListMembers.RemoveAt(nResult);
					Console.WriteLine("{0} 회원을 제거했습니다.", a_oName);
				}
				else
				{
					Console.WriteLine("존재하지 않는 회원입니다.");
				}
			}

			/** 회원을 검색한다 */
			public void SearchMember(string a_oName)
			{
				int nResult = this.FindMember(a_oName);

				// 회원이 존재 할 경우
				if(nResult >= 0)
				{
					this.ListMembers[nResult].ShowInfo();
				}
				else
				{
					Console.WriteLine("존재하지 않는 회원입니다.");
				}
			}

			/** 회원을 출력한다 */
			public void ShowInfos_Member()
			{
				for(int i = 0; i < this.ListMembers.Count; ++i)
				{
					this.ListMembers[i].ShowInfo();
					Console.WriteLine();
				}
			}

			/** 회원을 탐색한다 */
			private int FindMember(string a_oName)
			{
				for(int i = 0; i < this.ListMembers.Count; ++i)
				{
					// 회원이 존재 할 경우
					if(a_oName.Equals(this.ListMembers[i].Name))
					{
						return i;
					}
				}

				return -1;
			}
		}

		/** 메뉴를 탐색한다 */
		private static void P01ShowMenu_04()
		{
			Console.WriteLine("=====> 메뉴 <=====");
			Console.WriteLine("1. 회원 추가");
			Console.WriteLine("2. 회원 제거");
			Console.WriteLine("3. 회원 검색");
			Console.WriteLine("4. 모든 회원 정보");
			Console.WriteLine("5. 종료");
		}

		/** 회원을 추가한다 */
		private static void P01AddMember_04(CP01Manager_Member_04 oManager_Member)
		{
			Console.WriteLine("\n=====> 회원 추가 <=====");

			Console.Write("이름 : ");
			string oName = Console.ReadLine();

			Console.Write("전화번호 : ");
			string oNumber_Phone = Console.ReadLine();

			oManager_Member.AddMember(oName, oNumber_Phone);
		}

		/** 회원을 제거한다 */
		private static void P01RemoveMember_04(CP01Manager_Member_04 oManager_Member)
		{
			Console.WriteLine("\n=====> 회원 제거 <=====");

			Console.Write("이름 : ");
			string oName = Console.ReadLine();

			oManager_Member.RemoveMember(oName);
		}

		/** 회원을 검색한다 */
		private static void P01SearchMember_04(CP01Manager_Member_04 oManager_Member)
		{
			Console.WriteLine("\n=====> 회원 검색 <=====");

			Console.Write("이름 : ");
			string oName = Console.ReadLine();

			oManager_Member.SearchMember(oName);
		}

		/** 회원 정보를 출력한다 */
		private static void P01ShowInfos_Member_04(CP01Manager_Member_04 oManager_Member)
		{
			Console.WriteLine("\n=====> 모든 회원 정보 <=====");
			oManager_Member.ShowInfos_Member();
		}
#elif P_PRACTICE_P01_PRACTICE_04_03
		/**
		 * 메뉴
		 */
		private enum EP01Menu_04
		{
			NONE = -1,
			ADD_LINE,
			ADD_TRIANGLE,
			ADD_RECTANGLE,
			DRAW_SHAPES,
			EXIT,
			MAX_VAL
		}

		/**
		 * 색상
		 */
		private enum EP01Color_04
		{
			NONE = -1,
			RED,
			GREEN,
			BLUE,
			MAX_VAL
		}

		/**
		 * 도형
		 */
		private abstract class CP01Shape_04
		{
			public EP01Color_04 Color { get; private set; } = EP01Color_04.NONE;

			/** 생성자 */
			public CP01Shape_04(EP01Color_04 a_eColor)
			{
				this.Color = a_eColor;
			}

			/** 도형을 그린다 */
			public abstract void Draw();

			/** 색상 문자열을 반환한다 */
			public string GetColor_Str()
			{
				switch(this.Color)
				{
					case EP01Color_04.RED: return "빨간색";
					case EP01Color_04.GREEN: return "녹색";
					case EP01Color_04.BLUE: return "파란색";
				}

				return string.Empty;
			}
		}

		/**
		 * 선
		 */
		private class CP01Line_04 : CP01Shape_04
		{
			/** 생성자 */
			public CP01Line_04(EP01Color_04 a_eColor) : base(a_eColor)
			{
				// Do Something
			}

			/** 도형을 그린다 */
			public override void Draw()
			{
				Console.WriteLine("{0} 선을 그렸습니다.", this.GetColor_Str());
			}
		}

		/**
		 * 삼각형
		 */
		private class CP01Triangle_04 : CP01Shape_04
		{
			/** 생성자 */
			public CP01Triangle_04(EP01Color_04 a_eColor) : base(a_eColor)
			{
				// Do Something
			}

			/** 도형을 그린다 */
			public override void Draw()
			{
				Console.WriteLine("{0} 삼각형을 그렸습니다.", this.GetColor_Str());
			}
		}

		/**
		 * 사각형
		 */
		private class CP01Rectangle_04 : CP01Shape_04
		{
			/** 생성자 */
			public CP01Rectangle_04(EP01Color_04 a_eColor) : base(a_eColor)
			{
				// Do Something
			}

			/** 도형을 그린다 */
			public override void Draw()
			{
				Console.WriteLine("{0} 사각형을 그렸습니다.", this.GetColor_Str());
			}
		}

		/**
		 * 캔버스
		 */
		private class CP01Canvas_04
		{
			public List<CP01Shape_04> ListShapes { get; private set; } = new List<CP01Shape_04>();

			/** 도형을 추가한다 */
			public void AddShape(CP01Shape_04 a_oShape)
			{
				this.ListShapes.Add(a_oShape);
			}

			/** 도형을 그린다 */
			public void DrawShapes()
			{
				for(int i = 0; i < this.ListShapes.Count; ++i)
				{
					this.ListShapes[i].Draw();
				}
			}
		}

		/** 메뉴를 탐색한다 */
		private static void P01ShowMenu_04()
		{
			Console.WriteLine("=====> 메뉴 <=====");
			Console.WriteLine("1. 선 추가");
			Console.WriteLine("2. 삼각형 추가");
			Console.WriteLine("3. 사각형 추가");
			Console.WriteLine("4. 모든 도형 그리기");
			Console.WriteLine("5. 종료");
		}

		/** 도형을 생성한다 */
		private static CP01Shape_04 P01CreateShape_04(EP01Menu_04 a_eMenu)
		{
			int nColor_Min = (int)EP01Color_04.RED;
			int nColor_Max = (int)EP01Color_04.MAX_VAL;

			var oRandom = new Random();
			var eColor = (EP01Color_04)oRandom.Next(nColor_Min, nColor_Max);

			switch(a_eMenu)
			{
				case EP01Menu_04.ADD_LINE: return new CP01Line_04(eColor);
				case EP01Menu_04.ADD_TRIANGLE: return new CP01Triangle_04(eColor);
				case EP01Menu_04.ADD_RECTANGLE: return new CP01Rectangle_04(eColor);
			}

			return null;
		}
#endif // #if P_PRACTICE_P01_PRACTICE_04_01
	}
}
