using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingObject : InteractableObject
{
    //Class that handles moving object behaviour
    [Header("Moving object stats")]
    
    public Transform endPos;
    public float time;
    private EventSystem eventSystem;
    private AudioSource audioSource;
    private bool moved=false;
    private Vector3 endPostion;
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
        endPostion = endPos.position;
        audioSource = GetComponent<AudioSource>();
    }


    public override void Interact()
    {
        base.Interact();
        audioSource.Play();
        if (!moved) 
        {
            transform.DOMove(endPostion,time);
            moved = true;
        }
        else 
        {
            transform.DOMove(startPos, time);
            moved = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.parent = transform;
    }

    private void OnTriggerExit(Collider other)
    {
            other.gameObject.transform.parent = null;
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position,endPos.position);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(endPos.position, transform.localScale);
    }
}
