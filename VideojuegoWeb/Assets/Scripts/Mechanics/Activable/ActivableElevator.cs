using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;

public class ActivableElevator : ActivableObject
{
    //Class that handles elevator behaviour
    [Header("Elevator stats")]

    public Transform endPos;
    public float timeMoving;
    public float timeStatic;
    //private bool moved = false;
    private Vector3 endPosition;
    private Vector3 startPos;
    //private AudioSource audioSource1;
    //private AudioSource audioSource2;

    public float timeBeforeFall = 2;

    //public NavMeshSurface mesh;

    private void Start()
    {
        startPos = transform.position;
        endPosition = endPos.position;
        //audioSource1 = GetComponents<AudioSource>()[0]; // Accede al primer AudioSource
        //audioSource2 = GetComponents<AudioSource>()[1]; // Accede al segundo AudioSource
    }


    public override void Activate()
    {
        base.Activate();
        Move(endPosition);

    }
    private void Move(Vector3 pos)
    {
        transform.parent.transform.DOMove(pos, timeMoving).OnComplete(() => {
            DOVirtual.DelayedCall(timeStatic, () => Move((pos == endPosition) ? startPos : endPosition));
        });
    }

    public override void Deactivate()
    {
        base.Deactivate();
        StartCoroutine(waitDeactivate());
    }

    IEnumerator waitDeactivate()
    {
        yield return new WaitForSeconds(timeStatic);
        //audioSource2.Play();
        transform.DOShakePosition(timeBeforeFall, 0.1f).OnComplete(() => { transform.DOMove(startPos, timeMoving)/*.OnComplete(() => { mesh?.BuildNavMesh(); }); */; });
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
