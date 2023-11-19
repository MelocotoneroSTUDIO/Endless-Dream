using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class WideBeaconBehaviour : MonoBehaviour
{
    [Header("Beam ray")]
    public Transform beamOrigin;
    //public Transform beamDirection;

    [Header("Beacon movement")]
    public List<Transform> positions;
    public float timeToMove;
    private int count = 1;

    private Vector3 touchPosition;

    public Transform playerAim;

    public Collider[] colliders;
    private EventSystem eventSystem;

    private Tween posTween;
    private Tween rotTween;


    private void Start()
    {
        eventSystem = FindObjectOfType<EventSystem>();
        moveBeam(positions[1].position, positions[1].rotation.eulerAngles);
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
                        eventSystem.OnHit.Invoke();
                        DOTween.Kill(rotTween);
                        DOTween.Kill(posTween);
                        transform.parent.transform.position = positions[1].position;
                        transform.parent.transform.rotation = positions[1].rotation;
                        count = 1;
                    }
                }
            }
        }
    }


    void moveBeam(Vector3 pos, Vector3 rot)
    {
        rotTween = transform.parent.transform.DORotate(rot, timeToMove);
        posTween = transform.parent.transform.DOMove(pos, timeToMove).OnComplete(() => {
            count++;
            if (positions.Count <= count)
            {
                count = 0;
            }
            moveBeam(positions[count].position, positions[count].rotation.eulerAngles); });
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
        for(int i = 0; i < positions.Count; i++)
        {
            Gizmos.DrawLine(positions[i].position, positions[i+1>=positions.Count? 0:i+1].position);
        }


        if (playerAim != null)
        {
            Gizmos.color = Color.blue;
            Gizmos.DrawLine(beamOrigin.position, playerAim.position + new Vector3(0, 1, 0));
            Gizmos.DrawWireSphere(touchPosition, 3);
        }
    }
}
