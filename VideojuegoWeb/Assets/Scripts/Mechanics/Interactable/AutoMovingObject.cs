using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AutoMovingObject : MonoBehaviour
{
    //Class that handles moving object behaviour
    [Header("Moving object stats")]

    public Transform endPos;
    public float timeMoving;
    public float timeStatic;
    private Vector3 endPosition;
    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
        endPosition = endPos.position;

        Move(endPosition);
    }

    private void Move(Vector3 pos)
    {
        transform.parent.transform.DOMove(pos, timeMoving).OnComplete(() => {
            DOVirtual.DelayedCall(timeStatic, () => Move((pos == endPosition) ? startPos : endPosition));
        });
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
        Gizmos.DrawLine(transform.position, endPos.position);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(endPos.position, transform.localScale);
    }
}
