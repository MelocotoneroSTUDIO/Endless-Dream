using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CoinUI : MonoBehaviour
{

    EventSystem eventSystem;
    // Start is called before the first frame update
    void Start()
    {
        eventSystem = FindObjectOfType<EventSystem>();
        eventSystem.OnCoinPicked += UIUpdate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UIUpdate()
    {
        Debug.Log("Cojo Moneda");
    }
}
