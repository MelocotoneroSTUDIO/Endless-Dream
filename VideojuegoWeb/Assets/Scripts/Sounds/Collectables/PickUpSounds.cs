using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSounds : MonoBehaviour
{
    EventSystem eventSystem;
    // Start is called before the first frame update
    void Start()
    {
        eventSystem = FindObjectOfType<EventSystem>();
        eventSystem.OnCoinPicked += playCoinSound;
        eventSystem.OnTresurePicked += playTreasureSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playCoinSound()
    {

    }
    public void playTreasureSound()
    {

    }
}
