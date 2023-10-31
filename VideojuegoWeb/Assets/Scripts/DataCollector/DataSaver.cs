using System;
using System.IO;
using UnityEngine;

public static class DataSaver
{
    static string path = Application.streamingAssetsPath + "/Data/";
    public static void SaveData(DataClass data) 
    {
        Debug.Log(Application.streamingAssetsPath);
        //Upload data to txt or database (if connection available?)
        //Might need a serializable data class to store all data and transfer it
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "data.txt")))
        {
                outputFile.WriteLine(data.DataToString());
        }
    }
}
