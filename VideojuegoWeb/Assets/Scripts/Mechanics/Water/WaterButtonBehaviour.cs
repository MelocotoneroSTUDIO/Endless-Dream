using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterButtonBehaviour : MonoBehaviour
{
    public WaterBehaviour water;
    public int waterLevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            water.changeWaterLevel(waterLevel);
        }
    }

}
