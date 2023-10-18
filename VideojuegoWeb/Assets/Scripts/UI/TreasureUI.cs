using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TreasureUI : MonoBehaviour
{

    public List<Transform> treassureImages;
    private int treassureCount = 0;
    public float scaleFactor = 1f;


    EventSystem eventSystem;
    // Start is called before the first frame update
    void Start()
    {
        eventSystem = FindObjectOfType<EventSystem>();
        eventSystem.OnTreasurePicked += UIUpdate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UIUpdate()
    {
        treassureImages[treassureCount].DOScale(Vector3.one * scaleFactor, 1f);
        treassureCount++;
    }
}
