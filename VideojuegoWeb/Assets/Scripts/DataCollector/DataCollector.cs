using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataCollector : MonoBehaviour
{
    //Data variables updated onruntime
    DataClass data = new DataClass();
    public DataClass _data { get { return data; } }

    EventSystem eventSystem;
    private void Start()
    {
        eventSystem = GetComponent<EventSystem>();
        eventSystem.OnHit += addDeath;
        eventSystem.OnCoinPicked += addCoin;
        eventSystem.OnTreasurePicked += addTreasure;
    }

    //Need method/s to update current data
    public void addInteracion() 
    {
        data.interactions += 1;
    }

    public void setTime(float value)
    {
        data.time = value;
    }

    public void addCoin()
    {
        Debug.Log("Moneda");
        data.coins += 1;
    }
    public void addTreasure()
    {
        Debug.Log("Tesoro");
        data.treasures += 1;
    }
    public void addDeath()
    {
        Debug.Log("Muerte");
        data.deaths += 1;
    }

    public void SaveData() 
    {
        //Called at the end of the level
        //Needs to call static data saver to upload current data to the txt or database
        data.level = SceneManager.GetActiveScene().name;
        DataSaver.SaveData(data);
    }
}

[CustomEditor(typeof(DataCollector))]
public class ObjectBuilderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        DataCollector myScript = (DataCollector)target;
        if (GUILayout.Button("Save data"))
        {
            myScript.SaveData();
        }
    }
}