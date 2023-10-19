using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WaterBehaviour : MonoBehaviour
{
    public List<float> waterLevels = new List<float>();
    public float time = 1;

    private EventSystem eventSystem;

    private void Start()
    {
        eventSystem = FindObjectOfType<EventSystem>();
        eventSystem.OnHit += ResetWaterLevel;
    }

    public void changeWaterLevel(int level) 
    {
        if (level > waterLevels.Count) { level = waterLevels.Count; }
        transform.DOMoveY(waterLevels[level], time);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            eventSystem.OnHit.Invoke();
        }
    }

    public void ResetWaterLevel()
    {
        transform.DOMoveY(waterLevels[0], 0.2f);
    }
}
