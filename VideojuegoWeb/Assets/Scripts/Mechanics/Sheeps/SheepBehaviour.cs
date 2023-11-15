using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using DG.Tweening;

public enum SheepStates 
{
    idle,
    moving
}

public class SheepBehaviour : InteractableObject
{
    //Class that handles sheep behaviour
    [Header("Sheep info")]
    public Transform playerFollow;
    public float updateTime= 0.5f;
    public bool isFollowing = false;

    AudioSource audioSource;
    private NavMeshAgent agent=default;
    private Coroutine destinationCorutine;

    public SheepStates state = SheepStates.idle;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        agent = GetComponent<NavMeshAgent>();
    }

    public override void Interact()
    {
        base.Interact();
        agent.enabled = true;
        audioSource.Play();
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
        state = SheepStates.moving;
        agent.stoppingDistance = 2;
        agent.SetDestination(destination);
    }

    public void SetDestinationAndRotation(Vector3 destination, Vector3 rotation) 
    {
        state = SheepStates.moving;
        agent.stoppingDistance = 1;
        agent.SetDestination(destination);
        StartCoroutine(WaitDestinationComplete(rotation));
    }

    IEnumerator WaitDestinationComplete(Vector3 rotation) 
    {
        while (true) 
        {
            if (!agent.pathPending)
            {
                if (agent.remainingDistance <= agent.stoppingDistance)
                {
                    if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                    {
                        transform.DORotate(rotation, 1f).OnComplete(() =>
                        {
                            DOTween.Complete(transform); 
                            state = SheepStates.idle;
                            agent.enabled = false;
                        });
                        break;
                    }
                }
            }

            yield return null;
        }
    }

    public void stopPlayerFollow()
    {
        if (destinationCorutine != null) 
        {
            state = SheepStates.idle;
            StopCoroutine(destinationCorutine); //Stop updateDestinarion corutine
            SetDestination(transform.position); //Stop in place
            destinationCorutine = null;
            isFollowing = false;
        }
    }
}
