using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CastleDoor : ActivableObject
{
    //Class that handles castle door behaviour
    [Header("Door movement stats")]
    public float openingTime;
    public Vector3 rotation;

    public override void Activate()
    {
        transform.DORotate(rotation,openingTime);
    }
}
