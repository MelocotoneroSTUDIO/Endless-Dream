using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CastleDoor : ActivableObject
{
    public float activationTime;
    public Transform pivot;
    public Vector3 rotation;

    public override void Activate()
    {
        pivot.DORotate(rotation,activationTime);
    }
}
