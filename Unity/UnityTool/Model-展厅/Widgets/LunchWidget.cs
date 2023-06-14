/*
作者：Ran
项目：企业展厅
时间： 2023年06月09日 星期五 17:49
描述：
*/

using UnityEngine;
using UnityEngine.UI;
namespace Src.Widgets
{
	public class LunchWidget : WidgetBase
	{
		public override void Start()
		{
			base.Start();
			transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
			{
				Close(() =>
				{
					UiManage.Ins.CreateWindget(WindGetNames.HomeWidget);
				});
			});

		}
		public override void OnEnable()
		{
			base.OnEnable();

		}
	}
}
