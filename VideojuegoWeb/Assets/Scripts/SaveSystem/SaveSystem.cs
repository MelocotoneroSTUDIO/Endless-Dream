using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SaveSystem
{
    public static SaveInfo save = new SaveInfo();

    public static void SaveData()
    {
        //Save binary
    }

    //Missing call at game start to load save file
    //Also when DB is active need to pull save file from DB
    public static void LoadData() 
    {
        //Read binary
    }
}
