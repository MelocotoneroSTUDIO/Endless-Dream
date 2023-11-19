using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using DG.Tweening;

public class SheepPlacer : InteractableObject
{
    public List<SheepPlacementData> positions;
    public Vector3 faceRotation;
    int placedSheeps = 0;
    public ActivableObject attachedObject;
    public int requiredForActivation=1;

    private SheepManager sheepManager;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        sheepManager = FindObjectOfType<SheepManager>();
        audioSource = GetComponent<AudioSource>();
    }

    public override void Interact()
    {
        //On interact get a following sheep to a placing destination
        base.Interact();
        SheepBehaviour sheep;
        sheep = sheepManager.getFollowSheep();
        if (sheep != null) 
        {
            sheep.stopPlayerFollow();

            SheepPlacementData placementData=null;
            foreach(SheepPlacementData data in positions) 
            {
                if (!data.isOcuppied) 
                {
                    //Find first empty spot
                    placementData=data; 
                    break;
                }
            }
            if (placementData != null)
            {
                //If there is spot place sheep
                Debug.Log("PlacingSheep");
                sheepManager.removeSheep(sheep);
                sheep.SetDestinationAndRotation(placementData.Position.position,faceRotation);
                sheep.transform.parent = transform;
                placementData.isOcuppied = true;
                placementData.Sheep=sheep;
                placedSheeps++;
                activateObject(sheep);
            }
        }
    }

    public void removeSheep(SheepBehaviour sheep) 
    {
        foreach(SheepPlacementData data in positions) 
        {
            if (data.Sheep == sheep) 
            {
                sheepManager.addSheep(sheep);
                data.isOcuppied = false;
                data.Sheep.transform.parent=null;
                data.Sheep=null;
                placedSheeps--;
                attachedObject.Deactivate();
            }
        }
    }

    void activateObject(SheepBehaviour lastSheep) 
    {
        if (attachedObject != null) 
        {
            if (placedSheeps >= requiredForActivation) 
            {   
                //DOVirtual.DelayedCall(2.0f, () => audioSource.Play());
                StartCoroutine(waitForSheepArrival(lastSheep));
                //audioSource.Play();
            }
        }
    }

    IEnumerator waitForSheepArrival(SheepBehaviour sheep) 
    {
        yield return new WaitUntil(() => { return sheep.state != SheepStates.moving; });
        attachedObject.Activate();
    }

    private void OnDrawGizmos()
    {
        foreach (SheepPlacementData data in positions) 
        {
            Gizmos.DrawWireCube(data.Position.position,Vector3.one);
        }
    }
}
