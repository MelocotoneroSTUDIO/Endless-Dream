using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCollector : MonoBehaviour
{
    //Data variables updated onruntime
    DataClass data = new DataClass();

    EventSystem eventSystem;
    private void Start()
    {
        eventSystem = GetComponent<EventSystem>();
        eventSystem.OnHit += () => addValue(data.deaths);
        eventSystem.OnCoinPicked += () => addValue(data.coins);
        eventSystem.OnTreasurePicked += () => addValue(data.treasures);
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

    public void addValue(int data)
    {
        data += 1;
    }

    public void SaveData() 
    {
        //Called at the end of the level
        //Needs to call static data saver to upload current data to the txt or database
        DataSaver.SaveData(data);
    }
}
