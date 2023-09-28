using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BeaconBehaviour : MonoBehaviour
{
    public Transform beamOrigin;
    public Transform beamDirection;
    public Vector3 beamDirectionOffset;

    private Vector3 startPos;
    public Transform endPos;
    public float timeToMove;

    public Vector3 touchPosition;

    private void Start()
    {
        startPos = transform.position;
        moveBeamToEnd();
    }

    private void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(beamOrigin.position,beamDirection.position+beamDirectionOffset);
        if (Physics.Raycast(ray, out hit))
        {
            touchPosition = hit.point;
            Collider[] colliders = Physics.OverlapSphere(touchPosition, 0.5f);
            foreach (Collider collider in colliders)
            {
                if (collider.gameObject.tag == "Player") 
                {
                    Debug.Log("Pillado");
                }
            }
        }
    }


    void moveBeamToEnd() 
    {
        transform.DOMove(endPos.position, timeToMove).OnComplete(() => { moveBeamToStart(); });
    }

    void moveBeamToStart()
    {
        transform.DOMove(startPos, timeToMove).OnComplete(() => { moveBeamToEnd(); });
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(beamOrigin.position, beamDirection.position+beamDirectionOffset);
        Gizmos.DrawWireSphere(touchPosition,3);
    }
}
