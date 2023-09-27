using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TurningWall : InteractableObject
{
    public float rotationTime;
    private bool activated = false;
    public override void Interact()
    {
        if (!activated) 
        {
            transform.DORotate(new Vector3(0, 180, 0), rotationTime);
            activated = true;
        }
        else 
        {
            transform.DORotate(new Vector3(0, 0, 0), rotationTime);
            activated= false;
        }
        
    }

}
