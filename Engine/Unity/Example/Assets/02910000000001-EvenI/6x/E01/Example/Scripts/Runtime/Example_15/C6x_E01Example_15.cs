using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

using TMPro;

namespace _6x_E01Example
{
	/**
	 * Example 15
	 */
	public partial class C6x_E01Example_15 : CManager_Scene
	{
		#region 변수
		[Header("=====> Example 15 - UIs <=====")]
		[SerializeField] private TMP_Text m_oTMP_UIText_Result = null;
		#endregion // 변수

		#region 함수
		/** 초기화 */
		public override void Awake()
		{
			base.Awake();

			m_oTMP_UIText_Result.text = string.Format("Result : {0}",
				C6x_E01Storage_Result_14.Inst.Score);
		}

		/** 재시도 버튼을 처리한다 */
		public void UIHandleOnBtn_Retry()
		{
			CLoader_Scene.Inst.LoadScene(KDefine.G_N_SCENE_EXAMPLE_14);
		}

		/** 그만두기 버튼을 처리한다 */
		public void UIHandleOnBtn_Leave()
		{
			CLoader_Scene.Inst.LoadScene(KDefine.G_N_SCENE_EXAMPLE_13);
		}
		#endregion // 함수
	}
}
