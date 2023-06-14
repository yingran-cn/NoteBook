
/*
作者：Ran
项目：企业展厅
时间： 2023年06月08日 星期四 18:34
描述：
*/

using System;
using UnityEngine;
using UnityEngine.UI;
namespace Src.UiItem
{
	public class TextItem: ItemBase
	{
		Text _text;
		void Start()
		{
			_text = GetComponent<Text>();
		}
		async void OnEnable()
		{
			var content = await FileTool.LoadAsset(path);
			_text.text = content;
		}
	}
}
