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
    public float shakeStrength = 0.2f;
    public float shakeTime = 1;
    private AudioSource audioSource;

    Tween Tween;

    public override void Interact()
    {
        base.Interact();
        hits++;
        Tween = transform.DOShakePosition(shakeTime,shakeStrength);
        if (hits >= breakResistance) 
        {
            GetComponent<AudioSource>().Play();
            DOVirtual.DelayedCall(shakeTime, () => Destroy(gameObject));
        }
    }
}
