using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CastleDoor : ActivableObject
{
    public float activationTime;
    public Vector3 rotation;

    public override void Activate()
    {
        transform.DORotate(rotation,activationTime);
    }
}
