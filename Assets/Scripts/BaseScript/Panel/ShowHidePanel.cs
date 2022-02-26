using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShowHidePanel : BasePanel, IPointerDownHandler
{
    // 所有显示的面板
    public BasePanel[] shows;
    // 所有隐藏的面板
    public BasePanel[] hides;

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        for (int i = 0; i < shows.Length; i++)
        {
            shows[i].ShowPanel();
        }
        for (int i = 0; i < hides.Length; i++)
        {
            hides[i].HidePanel();
        }
    }
}
