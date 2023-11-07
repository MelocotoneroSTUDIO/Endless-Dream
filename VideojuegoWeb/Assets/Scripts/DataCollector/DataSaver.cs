using System;
using System.IO;
using UnityEngine;

public static class DataSaver
{
    

    //Packs personal data and level data and sends it to txt
    //TODO missing save into database
    public static void SaveData(DataClass data) 
    {
        //TODO change username to unknown player id for confidentiallity
        data.ID = SaveSystem.save.username;
        data.gender = SaveSystem.save.gender;
        data.age = SaveSystem.save.age;
        
        string writepath = Application.persistentDataPath + "/Data/Levels/";
        Directory.CreateDirectory(writepath);
        using (StreamWriter outputFile = new StreamWriter(writepath + data.level + ".txt"))
        {
            outputFile.WriteLine(data.DataToString());
        }
    }
}
