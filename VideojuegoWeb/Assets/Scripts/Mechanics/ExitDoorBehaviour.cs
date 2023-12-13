using Cinemachine;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorBehaviour : MonoBehaviour
{
    [SerializeField]
    TimerBehaviour timer;
    [SerializeField]
    DataCollector collector;
    public int levelID;
    public EndScreenBehaviour endScreen;
    [SerializeField] CinemachineVirtualCamera virtualCamera;
    [SerializeField] Transform enterPortalPos;

    // Start is called before the first frame update
    void Start()
    {
        if (timer == null)
        {
            timer = FindObjectOfType<TimerBehaviour>();
        }
        if (collector == null)
        {
            collector = FindObjectOfType<DataCollector>();
        }
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
                SaveSystem.save.completedLevels=levelID;
                Debug.Log("Completed levels = " + SaveSystem.save.completedLevels);
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
                virtualCamera.Priority = 50;
                player.blockPlayerMovement = true;
                player.transform.position = enterPortalPos.position;
                DOVirtual.DelayedCall(1f, () => { player.ActivateEndLevelAnimation();});
                
                //Trigger animation
            }

            //TODO Missing change to next level or menu pop up
            DOVirtual.DelayedCall(3f,() => {
                endScreen.gameObject.SetActive(true);
                endScreen.currentLevelID = levelID;
                endScreen.treasuresObtained = collector._data.treasures;
                endScreen.time = timer.getCurrentTimeSeconds();

                endScreen.ShowStats();
            });
            
        }
    }
}
