using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CastleDoor : ActivableObject
{
    [Header("Door movement")]
    public float openingTime;
    public Vector3 rotation;

    public override void Activate()
    {
        transform.DORotate(rotation,openingTime);
    }
}
