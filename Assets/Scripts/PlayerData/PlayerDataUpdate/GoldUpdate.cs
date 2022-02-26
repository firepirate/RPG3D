using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldUpdate : Base, IGoldUpdate
{
    public void goldUpdate(long gold)
    {
        GetComponent<Text>().text = gold.ToString();
    }
    private void OnEnable()
    {
        GetComponent<Text>().text = playerData.Gold.ToString();
    }
}
