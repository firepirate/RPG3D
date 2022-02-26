using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UserHeadImageUpdate : Base, IUserHeadImageUpdate
{
    public void userHeadImageUpdate(string userHeadImage)
    {
        GetComponent<Image>().sprite = AssetDatabase.LoadAssetAtPath(userHeadImage, typeof(Sprite)) as Sprite;
    }
    private void OnEnable()
    {
        GetComponent<Image>().sprite = AssetDatabase.LoadAssetAtPath(playerData.UserHeadImage, typeof(Sprite)) as Sprite;
    }
}
