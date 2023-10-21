using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    public Action OnCoinPicked;
    public Action OnTreasurePicked;
    public Action OnHit;
}
