using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class SheepBehaviour : InteractableObject
{
    //Class that handles sheep behaviour
    [Header("Sheep info")]
    public Transform playerFollow;
    public float updateTime= 0.5f;
    public bool isFollowing = false;

    private NavMeshAgent agent=default;
    private Coroutine destinationCorutine;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public override void Interact()
    {
        base.Interact();

        //If placed remove the sheep from the place
        if (transform.parent != null) 
        {
            transform.parent.GetComponent<SheepPlacer>()?.removeSheep(this);
        }

        //Follow the player or stop the sheep
        if (destinationCorutine == null) 
        {
            isFollowing = true;
            destinationCorutine = StartCoroutine(updateDestination(updateTime));
        }
        else 
        {
            stopPlayerFollow();
        }
    }



    IEnumerator updateDestination(float updateTime)
    {
        //Update follow position every updateTime
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
            StopCoroutine(destinationCorutine); //Stop updateDestinarion corutine
            SetDestination(transform.position); //Stop in place
            destinationCorutine = null;
            isFollowing = false;
        }
    }
}
