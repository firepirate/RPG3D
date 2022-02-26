using UnityEngine;

public class Base : MonoBehaviour
{
    public static PlayerData playerData;
    public static WorldSpeaceMode worldSpeaceMode;

    private void Awake()
    {
        if (playerData == null)
        {
            playerData = FindObjectOfType<PlayerData>();
        }
        if (worldSpeaceMode == null)
        {
            worldSpeaceMode = FindObjectOfType<WorldSpeaceMode>();
        }
    }
}
