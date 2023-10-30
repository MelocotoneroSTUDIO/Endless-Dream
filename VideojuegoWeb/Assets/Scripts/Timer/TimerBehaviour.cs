using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerBehaviour : MonoBehaviour
{
    TextMeshProUGUI timerText;
    float timerTime;
    int minutes,seconds,milliseconds;

    bool Pause = true;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        startTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Pause)
        {
           timerTime += Time.deltaTime;
            minutes = (int)(timerTime / 60f);
            seconds = (int)(timerTime - minutes * 60);
            milliseconds = (int)((timerTime - (int)timerTime) * 100f);

            timerText.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
        }
        
    }
    
    //Start stop timer methods, current time getter
    public void startTimer() 
    {
        Pause = false;
    }

    public void stopTimer() 
    {
        Pause = true;
    }
    
    public float getCurrentTimeSeconds() 
    {
        return timerTime;
    }

}
