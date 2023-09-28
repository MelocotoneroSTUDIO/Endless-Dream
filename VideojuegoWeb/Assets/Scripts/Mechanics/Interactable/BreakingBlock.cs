using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BreakingBlock : InteractableObject
{
    public int breakResistance;
    private int hits=0;
    public float shakeStrength = 1;
    public float shakeTime = 1;

    public override void Interact()
    {
        hits++;
        transform.DOShakePosition(shakeTime,shakeStrength);
        if (hits >= breakResistance) 
        {
        Destroy(gameObject);
        }
    }
}
