public enum WorldSpeaceType
{
    // 主菜单
    MAINMENU,
    // 普通的空间
    GENERAL
}

public enum WorldSpeaceDifficulty
{
    // 简单
    SIMPLE,
    // 困难
    DIFFICULT,
    // 地狱
    HELL
}

public class WorldSpeaceData
{
    // 空间类型
    public WorldSpeaceType worldSpeaceType;
    // 难度
    public WorldSpeaceDifficulty worldSpeaceDifficulty;

    public WorldSpeaceData()
    {
    }

    public WorldSpeaceData(WorldSpeaceType worldSpeaceType, WorldSpeaceDifficulty worldSpeaceDifficulty)
    {
        this.worldSpeaceType = worldSpeaceType;
        this.worldSpeaceDifficulty = worldSpeaceDifficulty;
    }
}
