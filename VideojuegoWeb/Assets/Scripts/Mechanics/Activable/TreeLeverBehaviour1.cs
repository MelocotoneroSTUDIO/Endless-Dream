using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeLeverBehaviour : InteractableObject
{
    //Class that handles lever behaviour
    //public ActivableObject connectedObject;
    public Animator puente;
    private bool isPlayerNear = false;

    public override void Interact()
    {
        base.Interact();
        if (isPlayerNear)
        {
            puente.SetTrigger("arriba");
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
