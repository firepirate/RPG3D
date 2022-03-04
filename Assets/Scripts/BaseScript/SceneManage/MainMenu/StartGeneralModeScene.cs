using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartGeneralModeScene : MonoBehaviour, IPointerClickHandler, IWorldSpeaceUpdate
{
    private bool isUpdateWorldMode;
    public void OnPointerClick(PointerEventData eventData)
    {
        // 序列化需要存储的数据
        SerializeUserData();

        DefultWorldMode();
        SceneManager.LoadScene("GeneralModeScene");
    }

    // 对外的事件调用，切换模式时
    public void WorldModeUpdate(WorldSpeaceType type, WorldSpeaceDifficulty difficulty)
    {
        Debug.Log("模式改变");
        isUpdateWorldMode = true;
        WorldSpeaceData data = new WorldSpeaceData(type, difficulty);
        SerializeData<WorldSpeaceData>.SerializeDataJson(Path.worldSpeacePath, data);
    }

    private void DefultWorldMode()
    {
        if (!isUpdateWorldMode)
        {
            // 写入默认值，简单模式
            WorldSpeaceData data = new WorldSpeaceData(WorldSpeaceType.GENERAL, WorldSpeaceDifficulty.SIMPLE);
            SerializeData<WorldSpeaceData>.SerializeDataJson(Path.worldSpeacePath, data);
        }
    }

    private void SerializeUserData()
    {
        PlayerData data = FindObjectOfType<PlayerData>();
        UserData userData = new UserData(data.UserName, data.UserHeadImage, data.Gold);
        SerializeData<UserData>.SerializeDataJson(Path.userDataPath, userData);
    }
}
