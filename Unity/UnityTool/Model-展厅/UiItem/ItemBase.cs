
/*
作者：Ran
项目：企业展厅
时间： 2023年06月08日 星期四 18:40
描述：
*/

using System;
using UnityEngine;
namespace Src.UiItem
{
	public class ItemBase: MonoBehaviour
	{
		/// <summary>
		/// 约定path跟物体名字绑定
		/// </summary>
		public string path;

		public virtual void Awake()
		{
			path = Application.streamingAssetsPath +"/"+ gameObject.name;
		}
	}
}
