using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserNameUpdate : Base, IUserNameUpdate
{
    public void userNameUpdate(string userName)
    {
        GetComponent<Text>().text = userName;
    }
    private void OnEnable()
    {
        GetComponent<Text>().text = playerData.UserName;
    }
}
