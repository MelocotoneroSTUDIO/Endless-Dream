using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableObject: MonoBehaviour
{
    //[HideInInspector]
    public DataCollector collector;
    private void Start()
    {
        collector = FindObjectOfType<DataCollector>();
    }
    //Abstract class for interactable objects
    public virtual void Interact() 
    {
        collector.addInteracion();
    }
}
