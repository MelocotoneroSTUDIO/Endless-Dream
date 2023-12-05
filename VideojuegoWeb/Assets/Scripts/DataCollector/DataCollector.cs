using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataCollector : MonoBehaviour
{
    //Data variables updated onruntime
    [SerializeField]
    DataClass data = new DataClass();
    public DataClass _data { get { return data; } }

    EventSystem eventSystem;
    DatabaseManager databaseManager;
    private void Start()
    {
        eventSystem = FindFirstObjectByType<EventSystem>();
        databaseManager = GetComponent<DatabaseManager>();
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
        //TODO change username to unknown player id for confidentiallity
        data.ID = SaveSystem.save.username;
        data.gender = SaveSystem.save.gender;
        data.age = SaveSystem.save.age;
        data.level = SceneManager.GetActiveScene().name;
        DataSaver.SaveData(data);
        databaseManager.SendData(data);
    }
}

#if UNITY_EDITOR
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
#endif