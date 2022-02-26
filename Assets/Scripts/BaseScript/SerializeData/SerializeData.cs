using System.IO;
using UnityEngine;

public class SerializeData<T>
{
    public static bool SerializeDataJson(string fileName, T data)
    {
        try
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            {
                string json = JsonUtility.ToJson(data);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(json);
                }
            }
            return true;
        }
        catch (System.Exception)
        {
            return false;
        }
    }
    public static T DeserializeDataJson(string fileName)
    {
        try
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string json = sr.ReadToEnd();
                T userData = JsonUtility.FromJson<T>(json);
                return userData;
            }
        }
        catch (System.Exception)
        {
            return default(T);
        }
    }
}
