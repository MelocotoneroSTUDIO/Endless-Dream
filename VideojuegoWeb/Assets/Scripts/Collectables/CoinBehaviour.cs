using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    //Class that handles coinBehaviour
    private EventSystem eventSystem;
    void Start()
    {
        eventSystem = FindObjectOfType<EventSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            eventSystem.OnCoinPicked.Invoke(); ;
            Destroy(gameObject);
        }
    }
}
