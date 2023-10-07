using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverBehaviour : InteractableObject
{
    //Class that handles lever behaviour
    public ActivableObject connectedObject;
    private bool isPlayerNear = false;

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
