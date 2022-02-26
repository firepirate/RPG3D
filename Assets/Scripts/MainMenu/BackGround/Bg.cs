using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bg : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float RotationCoefficient = 100;
    public Transform Ellen;
    private bool isRotationEllen;

    // 当前 Y 轴的值
    private float previousPositionX;

    public void OnPointerDown(PointerEventData eventData)
    {
        // Debug.Log("按下指针");
        isRotationEllen = true;
        previousPositionX = Input.mousePosition.x;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Debug.Log("松开指针");
        isRotationEllen = false;
        previousPositionX = 0f;
    }


    // Update is called once per frame
    void Update()
    {
        if (isRotationEllen)
        {
            float currentPositionX = Input.mousePosition.x;
            float reducePositionX = currentPositionX - previousPositionX;

            if (reducePositionX > 0)
            {
                // 向右滑动
                Ellen.transform.RotateAround(Ellen.transform.position, Vector3.up, Mathf.Abs(reducePositionX) * -RotationCoefficient * Time.deltaTime);
            }
            else if (reducePositionX < 0)
            {
                // 向左滑动
                Ellen.transform.RotateAround(Ellen.transform.position, Vector3.up, Mathf.Abs(reducePositionX) * RotationCoefficient * Time.deltaTime);
            }
            previousPositionX = currentPositionX;
        }
    }
}
