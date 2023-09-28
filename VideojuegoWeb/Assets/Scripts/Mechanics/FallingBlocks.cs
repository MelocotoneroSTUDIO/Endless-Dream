using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FallingBlocks : MonoBehaviour
{
    public float fallAmount;
    public float timeBeforeFall;
    public float fallingTime;
    public float resetTime;
    public float scaleTime;
    private Vector3 originalPos;
    private Vector3 originalScale;

    [Header("PlatformShake")]
    public float strength = 1;

    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
        originalScale = transform.localScale;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            transform.DOShakePosition(timeBeforeFall,strength).OnComplete(() => { blockFall(); });
        }
    }

    private void blockFall() 
    {
        transform.DOMoveY(transform.position.y - fallAmount, fallingTime).OnComplete(() => { transform.DOScale(Vector3.zero,scaleTime); StartCoroutine(Reset()); });
    }

    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(resetTime);
        transform.position = originalPos;
        transform.DOScale(originalScale,1);
    }
}
