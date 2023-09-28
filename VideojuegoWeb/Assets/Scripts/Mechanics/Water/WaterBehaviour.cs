using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WaterBehaviour : MonoBehaviour
{
    public List<float> waterLevels = new List<float>();
    public float time = 1;

    public void changeWaterLevel(int level) 
    {
        if (level > waterLevels.Count) { level = waterLevels.Count; }
        transform.DOMoveY(waterLevels[level], time);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
        //Glu Glu Glu
        }
    }
}
