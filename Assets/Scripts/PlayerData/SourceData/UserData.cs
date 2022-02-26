
public class UserData
{
    // 用户名
    public string userName;
    // 用户头像地址
    public string userHeadImage;
    // 用户金币
    public long gold;

    public UserData()
    {
    }

    public UserData(string userName, string userHeadImage, long gold)
    {
        this.userName = userName;
        this.userHeadImage = userHeadImage;
        this.gold = gold;
    }
}
