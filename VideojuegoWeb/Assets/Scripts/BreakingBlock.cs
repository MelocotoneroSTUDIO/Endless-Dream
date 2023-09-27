using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingBlock : InteractableObject
{
    public int breakResistance;
    private int hits=0;

    public override void Interact()
    {
        hits++;
        if (hits >= breakResistance) 
        {
        Destroy(gameObject);
        }
    }
}
