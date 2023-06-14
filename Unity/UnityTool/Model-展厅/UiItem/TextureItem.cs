
/*
作者：Ran
项目：企业展厅
时间： 2023年06月08日 星期四 17:56

描述：
*/

using System;
using UnityEngine;
using UnityEngine.UI;
namespace Src.UiItem
{
	public class TextureItem: ItemBase
	{
		RawImage _rawImage;

		public override void Awake()
		{
			base.Awake();
			_rawImage = gameObject.GetComponent<RawImage>();
		}
		async void OnEnable()
		{
			_rawImage.texture = await FileTool.LoadTexture2D( path, _rawImage.uvRect.width, _rawImage.uvRect.height);
		}
	}
}
