using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SheepBehaviour : InteractableObject
{
    public Transform playerFollow;

    private NavMeshAgent agent;
    private Coroutine destinationCorutine;
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public override void Interact()
    {
        base.Interact();
        if (destinationCorutine == null) 
        {
            destinationCorutine = StartCoroutine(updateDestination());
        }
        else 
        {
            StopCoroutine(destinationCorutine);
        }
    }



    IEnumerator updateDestination()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            SetDestination(playerFollow.position);
        }
    }

    public void SetDestination(Vector3 destination) 
    {
        agent.SetDestination(destination);
    }
}
