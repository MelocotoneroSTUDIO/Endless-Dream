using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.AI.Navigation;
using UnityEditor.AI;
using UnityEngine;
using UnityEngine.AI;

public class ActivableMovingObject : ActivableObject
{
    //Class that handles moving object behaviour
    [Header("Moving object stats")]

    public Transform endPos;
    public float time;
    private bool moved = false;
    private Vector3 endPostion;
    private Vector3 startPos;
    private AudioSource audioSource1;
    private AudioSource audioSource2;

    public float timeBeforeFall=2;

    public NavMeshSurface mesh;

    public bool autoDeactivate = false;


    private void Start()
    {
        startPos = transform.position;
        endPostion = endPos.position;
        AudioSource[] audiosources = GetComponents<AudioSource>();
        Debug.Log(audiosources.Length);
        audioSource1 = audiosources[0]; // Accede al primer AudioSource
        if (audiosources.Length > 1)
        {
            audioSource2 = audiosources[1]; // Accede al segundo AudioSource
        }
    }


    public override void Activate()
    {
        base.Activate();
        if (!moved)
        {
            audioSource1?.Play();
            transform.DOMove(endPostion, time).OnComplete(() => { mesh?.BuildNavMesh(); 
                if (autoDeactivate) 
                {
                    Deactivate();
                }});
            moved = true;
        }

        
    }

    public override void Deactivate()
    {
        base.Deactivate();
        if (moved)
        {
            StartCoroutine(waitDeactivate());
            
        }
    }

    IEnumerator waitDeactivate() 
    {
        yield return new WaitForSeconds(timeBeforeFall);
        audioSource2?.Play();
        transform.DOShakePosition(time, 0.1f).OnComplete(() => { transform.DOMove(startPos, time).OnComplete(() => { mesh?.BuildNavMesh(); }); });
        
        moved = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.parent = transform;
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.transform.parent = null;
    }


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, endPos.position);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(endPos.position, transform.localScale);
    }
}
