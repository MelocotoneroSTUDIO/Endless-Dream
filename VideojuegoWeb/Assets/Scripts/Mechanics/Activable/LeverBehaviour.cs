using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBehaviour : InteractableObject
{
    public ActivableObject connectedObject;
    private bool isPlayerNear = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        if (isPlayerNear)
        {
            connectedObject.Activate();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
        isPlayerNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isPlayerNear = false;
        }
    }
}
