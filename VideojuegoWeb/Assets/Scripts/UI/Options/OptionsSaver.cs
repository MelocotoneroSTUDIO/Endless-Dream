using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class OptionsSaver
{
    public static OptionsData Options = new OptionsData();

    public static void SaveOptions() 
    {

        string writepath = Application.persistentDataPath + "/Data/Options/";
        Directory.CreateDirectory(writepath);

        try 
        {
            string dataToStore = JsonUtility.ToJson(Options,true);
            using (FileStream stream = new FileStream(writepath + "settings.json", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataToStore);
                }
            }
        }
        catch 
        {
            Debug.LogError("Error occured when saving settings.");
        }

    }

    public static void LoadOptions() 
    {
        string readpath = Application.persistentDataPath + "/Data/Options/settings.json";
        if (File.Exists(readpath)) 
        {
            try 
            {
                string dataToLoad = "";
                using (FileStream stream = new FileStream(readpath, FileMode.Open)) 
                {
                    using (StreamReader reader = new StreamReader(stream)) 
                    {
                        dataToLoad = reader.ReadToEnd();
                    }
                }
                Options = JsonUtility.FromJson<OptionsData>(dataToLoad);
            }
            catch 
            {
                Debug.LogError("Error occured when loading settings.");
            }
        }
    }
}
