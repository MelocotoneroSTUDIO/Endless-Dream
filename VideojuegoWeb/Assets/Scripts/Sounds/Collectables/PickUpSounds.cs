using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSounds : MonoBehaviour
{
    EventSystem eventSystem;
    AudioSource audioSource;
    public AudioClip coinSound;
    public AudioClip treasureSound;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        eventSystem = FindObjectOfType<EventSystem>();
        eventSystem.OnCoinPicked += playCoinSound;
        eventSystem.OnTreasurePicked += playTreasureSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playCoinSound()
    {
        audioSource.clip = coinSound;
        audioSource.Play();
    }
    public void playTreasureSound()
    {
        audioSource.clip = treasureSound    ;
        audioSource.Play();
    }
}


