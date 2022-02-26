using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class WorldSpeaceDifficultyUpdateEvent : UnityEvent<WorldSpeaceDifficulty> { }

public class WorldSpeaceMode : MonoBehaviour
{
    // 空间类型
    [SerializeField]
    private WorldSpeaceType worldSpeaceType;
    // 难度
    [SerializeField]
    private WorldSpeaceDifficulty worldSpeaceDifficulty;
    public WorldSpeaceDifficultyUpdateEvent worldSpeaceDifficultyUpdate;

    public WorldSpeaceType WorldSpeaceType { get => worldSpeaceType; }
    public WorldSpeaceDifficulty WorldSpeaceDifficulty { get => worldSpeaceDifficulty;
        set
        {
            worldSpeaceDifficulty = value;
            worldSpeaceDifficultyUpdate.Invoke(value);
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

    }

    private void InitPlayerData()
    {
        // 反序列化用户数据
        WorldSpeaceData data = SerializeData<WorldSpeaceData>.DeserializeDataJson(Path.worldSpeacePath);
        this.worldSpeaceType = data.worldSpeaceType;
        this.WorldSpeaceDifficulty = data.worldSpeaceDifficulty;
    }
}