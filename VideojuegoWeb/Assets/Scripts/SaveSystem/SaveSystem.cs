using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static SaveInfo save = new SaveInfo();

    public static void SaveData()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string savePath = Application.persistentDataPath + "/Saves/";

        Directory.CreateDirectory(savePath);
        FileStream stream = new FileStream(savePath + "save.sav", FileMode.Create);

        //Save binary
        formatter.Serialize(stream, save);
        stream.Close(); 
    }

    //TODO Missing call at game start to load save file
    //TODO Also when DB is active need to pull save file from DB at login
    public static void LoadData() 
    {
        string loadPath = Application.persistentDataPath + "/Saves/";
        Directory.CreateDirectory(loadPath);

        if (File.Exists(loadPath + "save.sav")) 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(loadPath + "save.sav", FileMode.Open);

            //Load binary
            save = formatter.Deserialize(stream) as SaveInfo;
            stream.Close();
        }
        else 
        {
            Debug.LogError("Save file not found in " + loadPath);
        }
    }
}
