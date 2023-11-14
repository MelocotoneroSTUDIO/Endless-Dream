using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SheepPlacementData
{
    public Transform Position;
    public bool isOcuppied=false;
    public SheepBehaviour Sheep = null;
}
