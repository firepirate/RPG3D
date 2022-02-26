using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NumberChanged : UnityEvent<int> { }

public class HorizontalSlider : MonoBehaviour
{
    public NumberChanged numberChanged;

    private Scrollbar scrollbar;
    private void Awake()
    {
        scrollbar = GetComponent<Scrollbar>();
        scrollbar.onValueChanged.AddListener(OnValueChanged);
    }

    private void OnValueChanged(float value)
    {
        // scrollbar.size = 0;
        Debug.Log("滑动");
    }
}