using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;

public class BeaconBehaviour : MonoBehaviour
{
    [Header("Beam ray")]
    public Transform beamOrigin;
    public Transform beamDirection;

    [Header("Beacon movement")]
    //private Vector3 startPos;
    //public Transform endPos;
    public List<Transform> positions;
    public float timeToMove;
    private int count = 1;

    private Vector3 touchPosition;
    private EventSystem eventSystem;

    private Tween posTween;
    private Tween rotTween;

    private void Start()
    {
        //startPos = transform.position;
        //moveBeamToEnd();
        eventSystem = FindObjectOfType<EventSystem>();
        moveBeam(positions[1].position, positions[1].rotation.eulerAngles);

    }

    private void Update()
    {
        RaycastHit hit;
        Vector3 direction = beamDirection.position - beamOrigin.position;
        Ray ray = new Ray(beamOrigin.position,direction);
        if (Physics.Raycast(ray, out hit))
        {
            touchPosition = hit.point;
            Collider[] colliders = Physics.OverlapSphere(touchPosition, 0.5f);
            foreach (Collider collider in colliders)
            {
                if (collider.gameObject.tag == "Player") 
                {
                    Debug.Log("Pillado");
                    eventSystem.OnHit.Invoke();

                    rotTween.Kill();
                    posTween.Kill();
                    transform.parent.transform.position = positions[0].position;
                    transform.parent.transform.rotation = positions[0].rotation;
                    count = 1;

                    moveBeam(positions[1].position, positions[1].rotation.eulerAngles);
                }
            }
        }
    }


    void moveBeam(Vector3 pos, Vector3 rot) 
    {
        //transform.DOMove(endPos.position, timeToMove).OnComplete(() => { moveBeamToStart(); });
        rotTween = transform.parent.transform.DORotate(rot, timeToMove);
        posTween = transform.parent.transform.DOMove(pos, timeToMove).OnComplete(() => {
            count++;
            if (positions.Count <= count)
            {
                count = 0;
            }
            moveBeam(positions[count].position, positions[count].rotation.eulerAngles);
        });
    }

    private void OnDrawGizmos()
    {
        //Moving guides gizmo
        Gizmos.color = Color.red;
        for (int i = 0; i < positions.Count; i++)
        {
            Gizmos.DrawLine(positions[i].position, positions[i + 1 >= positions.Count ? 0 : i + 1].position);
        }

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(beamOrigin.position, beamDirection.position);
        Gizmos.DrawWireSphere(touchPosition,3);
    }
}
