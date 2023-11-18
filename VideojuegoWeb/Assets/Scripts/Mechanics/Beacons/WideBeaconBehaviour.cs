using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WideBeaconBehaviour : MonoBehaviour
{
    [Header("Beam ray")]
    public Transform beamOrigin;
    //public Transform beamDirection;

    [Header("Beacon movement")]
    private Vector3 startPos;
    public Transform endPos;
    public float timeToMove;

    private Vector3 touchPosition;

    public Transform playerAim;

    public Collider[] colliders;


    private void Start()
    {
        startPos = transform.position;
        moveBeamToEnd();
    }

    private void Update()
    {
        if (playerAim != null)
        {
            RaycastHit hit;
            Vector3 direction = (playerAim.position + new Vector3(0,1,0)) - beamOrigin.position;
            Ray ray = new Ray(beamOrigin.position, direction);
            if (Physics.Raycast(ray, out hit))
            {
                touchPosition = hit.point;
                colliders = Physics.OverlapSphere(touchPosition, 0.2f);
                foreach (Collider collider in colliders)
                {
                    if (collider.tag == "Player")
                    {
                        Debug.Log("Pillado");
                        //Mising behaviour when catched
                    }
                }
            }
        }
    }


    void moveBeamToEnd()
    {
        transform.parent.transform.DOMove(endPos.position, timeToMove).OnComplete(() => { moveBeamToStart(); });
    }

    void moveBeamToStart()
    {
        transform.parent.transform.DOMove(startPos, timeToMove).OnComplete(() => { moveBeamToEnd(); });
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            playerAim = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerAim = null;
        }
    }

    private void OnDrawGizmos()
    {
        //Moving guides gizmo
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, endPos.position);

        if (playerAim != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(beamOrigin.position, playerAim.position + new Vector3(0, 1, 0));
            Gizmos.DrawWireSphere(touchPosition, 3);
        }
    }
}
