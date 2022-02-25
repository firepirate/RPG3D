using UnityEngine;
using UnityEngine.EventSystems;

public class ExitGame : BasePanel, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        Debug.Log("退出游戏");
    }
}
