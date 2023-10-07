using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BeaconBehaviour : MonoBehaviour
{
    [Header("Beam ray")]
    public Transform beamOrigin;
    public Transform beamDirection;

    [Header("Beacon movement")]
    private Vector3 startPos;
    public Transform endPos;
    public float timeToMove;

    private Vector3 touchPosition;

    private void Start()
    {
        startPos = transform.position;
        moveBeamToEnd();
    }

    private void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(beamOrigin.position,beamDirection.position);
        if (Physics.Raycast(ray, out hit))
        {
            touchPosition = hit.point;
            Collider[] colliders = Physics.OverlapSphere(touchPosition, 0.5f);
            foreach (Collider collider in colliders)
            {
                if (collider.gameObject.tag == "Player") 
                {
                    Debug.Log("Pillado");
                    //Mising behaviour when catched
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

    private void OnDrawGizmosSelected()
    {
        //Moving guides gizmo
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, endPos.position);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(beamOrigin.position, beamDirection.position);
        Gizmos.DrawWireSphere(touchPosition,3);
    }
}
