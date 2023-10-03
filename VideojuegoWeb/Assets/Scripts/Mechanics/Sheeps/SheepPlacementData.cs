using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SheepPlacementData
{
    public Vector3 Position;
    public bool isOcuppied=false;
    public SheepBehaviour Sheep = null;
}
