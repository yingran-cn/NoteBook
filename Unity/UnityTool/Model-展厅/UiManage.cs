
/*
作者：Ran
项目：企业展厅
时间： 2023年06月08日 星期四 16:51
描述：
*/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
namespace Src
{
	public class UiManage: MonoBehaviour
	{
		[SerializeField] List<GameObject> widgets;
		Transform WidgetRoot;

		public static UiManage Ins;
		void Awake()
		{
			Ins = this;
			WidgetRoot = GameObject.Find("Canvas").transform;
		}
		void Start()
		{
			//初始化首页
			CreateWindget(WindGetNames.LunchWidget);
		}

		public GameObject WidgetsByName(string windgetName)
		{
			return widgets.Find(o => o.name == windgetName);
		}

		public void CreateWindget(string windgetName)
		{
			Instantiate(WidgetsByName(windgetName), WidgetRoot);
		}
		
		

	}
}
