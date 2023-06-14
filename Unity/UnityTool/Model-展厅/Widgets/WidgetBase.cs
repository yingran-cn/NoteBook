
/*
作者：Ran
项目：企业展厅
时间： 2023年06月09日 星期五 16:16
描述：
*/

using System;
using DG.Tweening;
using UnityEngine;
namespace Src.Widgets
{
	public class WidgetBase: MonoBehaviour
	{
		RectTransform _rectTransform;

		public virtual void Awake()
		{
			_rectTransform = GetComponent<RectTransform>();
			_rectTransform.localScale = Vector3.zero;
		}
		public virtual void Start()
		{
			
		}
		public virtual void OnEnable()
		{
			Open();
		}

		public virtual void Open()
		{
			_rectTransform.DOScale(Vector3.one, 0.5f);
		}

		public virtual void Close(Action callback)
		{
			var dt = gameObject.transform.DOScale(Vector3.zero, 0.5f);
			dt.onComplete += () =>
			{
				callback.Invoke();
				Destroy(gameObject);
			};
		}
		
	}
}
