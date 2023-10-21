using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BreakingBlock : InteractableObject
{
    //Class that handles breaking block behaviour
    [Header("Breaking block stats")]
    public int breakResistance;
    private int hits=0;
    [Header("On hit shake stats")]
    public float shakeStrength = 1;
    public float shakeTime = 1;

    public override void Interact()
    {
        base.Interact();
        hits++;
        transform.DOShakePosition(shakeTime,shakeStrength);
        if (hits >= breakResistance) 
        {
            DOTween.Kill(transform);
            Destroy(gameObject);
        }
    }
}
