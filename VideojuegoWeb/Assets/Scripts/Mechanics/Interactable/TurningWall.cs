using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TurningWall : InteractableObject
{
    //Class that handles Turning wall behaviour
    [Header("Turning wall stats")]
    public float rotationTime;
    private bool activated = false;
    public override void Interact()
    {
        base.Interact();
        if (!activated) 
        {
            transform.parent.DORotate(new Vector3(0, 180, 0), rotationTime);
            activated = true;
        }
        else 
        {
            transform.parent.DORotate(new Vector3(0, 0, 0), rotationTime);
            activated= false;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            other.transform.parent = transform.parent;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.transform.parent = null;
        }
    }
}
