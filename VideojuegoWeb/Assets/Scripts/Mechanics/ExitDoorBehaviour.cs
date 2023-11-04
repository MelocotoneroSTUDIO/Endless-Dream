using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorBehaviour : MonoBehaviour
{
    TimerBehaviour timer;
    DataCollector collector;

    // Start is called before the first frame update
    void Start()
    {
        timer = FindObjectOfType<TimerBehaviour>();
        collector = FindObjectOfType<DataCollector>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timer.stopTimer();
            collector.setTime(timer.getCurrentTimeSeconds());
            collector.SaveData();
            //Data has been saved proceed to load next level
            //Missing change to next level or menu pop up
        }
    }
}
