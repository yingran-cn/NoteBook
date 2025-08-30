using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 挂载到需要适配安全区域的UI上
/// </summary>
public class MatchSafeArea : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;
    // Start is called before the first frame update

    private void Awake()
    {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
    }

    void Start()
    {

        if (canvas == null)
        {
            Debug.LogError("MatchSafeArea canvas is null");
            return;
        }
        
        var safeArea = Screen.safeArea;
        
        var canvasRect = canvas.GetComponent<RectTransform>();
        var screenScale = canvasRect.rect.width / Screen.width;
        var max = Mathf.Max(safeArea.x, Screen.width - (safeArea.x + safeArea.width)) * screenScale;

        var rect = this.GetComponent<RectTransform>();
        rect.offsetMin = new Vector2(max,rect.offsetMin.y);
        rect.offsetMax = new Vector2(-max,rect.offsetMax.y);
    }

}
