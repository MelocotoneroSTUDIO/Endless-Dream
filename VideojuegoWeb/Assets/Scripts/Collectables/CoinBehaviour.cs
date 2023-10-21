using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinBehaviour : MonoBehaviour
{
    //Class that handles coinBehaviour
    private EventSystem eventSystem;
    [Header("Coin rotation stats")]
    public Vector3 rot;
    public float rotTime;
    void Start()
    {
        eventSystem = FindObjectOfType<EventSystem>();
        transform.DORotate(rot, rotTime).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            eventSystem.OnCoinPicked.Invoke();
            DOTween.Kill(transform);
            Destroy(gameObject);
        }
    }
}
