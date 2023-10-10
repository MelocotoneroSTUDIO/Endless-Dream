using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureUI : MonoBehaviour
{

    EventSystem eventSystem;
    // Start is called before the first frame update
    void Start()
    {
        eventSystem = FindObjectOfType<EventSystem>();
        eventSystem.OnTreasurePicked += UIUpdate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UIUpdate()
    {
        Debug.Log("Cojo tesoro");
    }
}
