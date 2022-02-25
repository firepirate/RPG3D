using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameSetingBtn : ShowHidePanel
{
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        GameSetingPanel gameSetingPanel = GetComponentInParent<GameSetingPanel>();
        if (gameSetingPanel.CurrentShowPanel != shows[0])
        {
            gameSetingPanel.CurrentShowPanel.HidePanel();
            gameSetingPanel.CurrentShowPanel = shows[0];
        }
    }
}
