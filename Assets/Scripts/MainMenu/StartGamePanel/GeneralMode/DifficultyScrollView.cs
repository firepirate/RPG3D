using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System;

[Serializable]
public class GeneralModeChanged : UnityEvent<WorldSpeaceType, WorldSpeaceDifficulty> { }

// 继承自动滚动组件
public class DifficultyScrollView : MonoBehaviour, IBeginDragHandler, IEndDragHandler
{
    public GeneralModeChanged modeChanged;
    public StartGeneralModeScene worldSpeaceUpdate;

    private ScrollRect scrollRect;
    private float[] difficultyListIndex = { 0f, 0.5f, 1f };
    private void Awake()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    private void Start()
    {
        // worldSpeaceUpdate = GameObject.FindObjectOfType<StartGeneralModeScene>();
        // modeChanged.AddListener(worldSpeaceUpdate.WorldModeUpdate);
    }

    // 改变模式时触发
    private void NumberChanged(int number)
    {
        modeChanged.Invoke(WorldSpeaceType.GENERAL, (WorldSpeaceDifficulty)number);
    }

    private void MoveIndex()
    {
        float minNumer = Mathf.Abs(scrollRect.horizontalNormalizedPosition - difficultyListIndex[0]);
        float index = difficultyListIndex[0];
        int worldSpeaceIndex = 0;
        for (int i = 1; i < difficultyListIndex.Length; i++)
        {
            if (minNumer > Mathf.Abs(scrollRect.horizontalNormalizedPosition - difficultyListIndex[i]))
            {
                minNumer = Mathf.Abs(scrollRect.horizontalNormalizedPosition - difficultyListIndex[i]);
                index = difficultyListIndex[i];
                worldSpeaceIndex = i;
            }
        }
        scrollRect.horizontalNormalizedPosition = index;
        NumberChanged(worldSpeaceIndex);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("开始托拽");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("结束托拽");
        MoveIndex();
    }
}
