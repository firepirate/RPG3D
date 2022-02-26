using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 继承自动滚动组件
public class DifficultyScrollView : HorizontalSlider
{
    private IWorldSpeaceUpdate worldSpeaceUpdate;
    private void Awake()
    {
        worldSpeaceUpdate = FindObjectOfType<StartGeneralModeScene>();
        numberChanged.AddListener(NumberChanged);
    }

    // 改变模式时触发
    private void NumberChanged(int number)
    {

    }
}
