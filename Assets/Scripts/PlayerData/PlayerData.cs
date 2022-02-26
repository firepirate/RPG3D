using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class UserNameUpdateEvent : UnityEvent<string> { }
[Serializable]
public class UserHeadImageUpdateEvent : UnityEvent<string> { }
[Serializable]
public class GoldUpdateEvent : UnityEvent<long> { }

public class PlayerData : MonoBehaviour
{
    // 用户名
    [SerializeField]
    private string userName;
    public UserNameUpdateEvent userNameUpdate;
    // 用户头像地址
    [SerializeField]
    private string userHeadImage;
    public UserHeadImageUpdateEvent userHeadImageUpdate;
    // 用户金币
    [SerializeField]
    private long gold;
    public GoldUpdateEvent goldUpdate;

    public string UserName { get => userName;
        set
        {
            this.userName = value;
            this.userNameUpdate.Invoke(value);
        }
    }
    public string UserHeadImage { get => userHeadImage;
        set
        {
            this.userHeadImage = value;
            this.userHeadImageUpdate.Invoke(value);
        }
    }
    public long Gold { get => gold;
        set
        {
            this.gold = value;
            this.goldUpdate.Invoke(value);
        }
    }

    private void Awake()
    {
        AddAllListener();
    }

    private void Start()
    {
        InitPlayerData();
    }

    private void AddAllListener()
    {
        // 添加全部需要监听的函数，用接口
        AddUserNameUpdateListener();
        AddUserHeadImageUpdateListener();
        AddGoldUpdateListener();
    }

    private void AddUserNameUpdateListener()
    {
        IUserNameUpdate[] userNameUpdates = FindObjectsOfType<UserNameUpdate>();
        for (int i = 0; i < userNameUpdates.Length; i++)
        {
            userNameUpdate.AddListener(userNameUpdates[i].userNameUpdate);
        }
    }
    private void AddUserHeadImageUpdateListener()
    {
        IUserHeadImageUpdate[] userHeadImageUpdates = FindObjectsOfType<UserHeadImageUpdate>();
        for (int i = 0; i < userHeadImageUpdates.Length; i++)
        {
            userHeadImageUpdate.AddListener(userHeadImageUpdates[i].userHeadImageUpdate);
        }
    }
    private void AddGoldUpdateListener()
    {
        IGoldUpdate[] goldUpdates = FindObjectsOfType<GoldUpdate>();
        for (int i = 0; i < goldUpdates.Length; i++)
        {
            goldUpdate.AddListener(goldUpdates[i].goldUpdate);
        }
    }

    private void InitPlayerData()
    {
        // 反序列化用户数据
        UserData data = SerializeData<UserData>.DeserializeDataJson(Path.userDataPath);
        // Debug.Log(data.gold);
        this.UserName = data.userName;
        this.UserHeadImage = data.userHeadImage;
        this.Gold = data.gold;
    }
}
