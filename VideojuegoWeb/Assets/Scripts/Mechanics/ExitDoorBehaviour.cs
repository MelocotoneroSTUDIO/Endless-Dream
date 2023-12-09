using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorBehaviour : MonoBehaviour
{
    TimerBehaviour timer;
    DataCollector collector;
    public int levelID;
    public EndScreenBehaviour endScreen;

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
            
            if(levelID >= SaveSystem.save.completedLevels) 
            {
                //Only if its first time level completion add one to completed levels
                SaveSystem.save.completedLevels++;
            }
            if (SaveSystem.save.levelStars[levelID] < collector._data.treasures) 
            {
                //If saved stars is lower than collected stars update saved stars
                SaveSystem.save.levelStars[levelID] = collector._data.treasures;
            }
            SaveSystem.save.coins += collector._data.coins;
            //Save file info updated proceed to save
            SaveSystem.SaveData();

            //Data has been saved to stats and savefile proceed to load next level

            PlayerMovement player = other.GetComponent<PlayerMovement>();
            if (player != null) 
            {
                player.blockPlayerMovement = true;
                //Trigger animation
            }

            //TODO Missing change to next level or menu pop up
            endScreen.gameObject.SetActive(true);
            endScreen.currentLevelID = levelID;
            endScreen.treasuresObtained = collector._data.treasures;
            endScreen.time = timer.getCurrentTimeSeconds();

            endScreen.ShowStats();
        }
    }
}
