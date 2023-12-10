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
    private AudioSource audioSource1;
    private AudioSource audioSource2;

    private Vector3 originalPos;
    private Vector3 originalScale;

    [Header("PlatformShake")]
    public float strength = 1;

    private bool hasWalked = false;
    private bool hasFallen = false;


    // Start is called before the first frame update
    void Start()
    {
        originalPos = transform.position;
        originalScale = transform.localScale;
        audioSource1= GetComponents<AudioSource>()[0];
        audioSource2= GetComponents<AudioSource>()[1];
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            if (!hasWalked)
                {
                    //Sonido caída:
                    audioSource1.Play();
                    hasWalked = true;
                }
            //audioSource1.Play();
            transform.DOShakePosition(timeBeforeFall,strength).OnComplete(() => { blockFall(); });
        }
    }
    

    private void blockFall() 
    {
        if (!hasFallen)
        {
            //Sonido caída:
            audioSource2.Play();
            hasFallen = true;
        }
        transform.DOMoveY(transform.position.y - fallAmount, fallingTime).OnComplete(() => { transform.DOScale(Vector3.zero,scaleTime); StartCoroutine(Reset()); });
        
    }

    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(resetTime);
        transform.position = originalPos;
        transform.DOScale(originalScale,1);
        hasWalked=false;
        hasFallen=false;
    }
}
