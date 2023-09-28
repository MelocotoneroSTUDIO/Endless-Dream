using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingObject : InteractableObject
{
    private Vector3 startPos;
    public Transform endPos;
    public float time;
    private bool moved=false;

    private void Start()
    {
        startPos = transform.position;
    }


    public override void Interact()
    {
        if (!moved) 
        {
            transform.DOMove(endPos.position,time);
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
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.parent = null;
        }
    }

}
