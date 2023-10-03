using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class SheepBehaviour : InteractableObject
{
    public Transform playerFollow;
    public float updateTime= 0.5f;
    public bool isFollowing = false;

    private NavMeshAgent agent=default;
    private Coroutine destinationCorutine;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public override void Interact()
    {
        base.Interact();

        if (transform.parent != null) 
        {
            transform.parent.GetComponent<SheepPlacer>()?.removeSheep(this);
        }

        if (destinationCorutine == null) 
        {
            isFollowing = true;
            destinationCorutine = StartCoroutine(updateDestination(updateTime));
        }
        else 
        {
            StopCoroutine(destinationCorutine);
            destinationCorutine = null;
            isFollowing = false;
        }
    }



    IEnumerator updateDestination(float updateTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(updateTime);
            SetDestination(playerFollow.position);
        }
    }

    public void SetDestination(Vector3 destination) 
    {
        agent.SetDestination(destination);
    }

    public void stopPlayerFollow()
    {
        if (destinationCorutine != null) 
        {
        StopCoroutine (destinationCorutine);
        }
    }
}
