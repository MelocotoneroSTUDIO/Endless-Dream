using System;
using System.IO;
using UnityEngine;

public static class DataSaver
{
    static string writepath = Application.streamingAssetsPath + "/Data/Levels/";
    static string readpath = Application.streamingAssetsPath + "/Data/Personal/PData.txt";
    public static void SaveData(DataClass data) 
    {
        Debug.Log(Application.streamingAssetsPath);
        //Missing add gender and age from save
        using (StreamReader reader = new StreamReader(readpath)) 
        {
            data.gender = reader.ReadLine();
            data.age = int.Parse(reader.ReadLine());
        }

        //Upload data to txt or database (if connection available?)
        //Might need a serializable data class to store all data and transfer it
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(writepath, "data.txt")))
        {
            outputFile.WriteLine(data.DataToString());
        }
    }
}
