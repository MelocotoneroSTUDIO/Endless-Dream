using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepPlacer : InteractableObject
{
    public List<SheepPlacementData> positions;

    private SheepManager sheepManager;

    // Start is called before the first frame update
    void Start()
    {
        sheepManager = FindObjectOfType<SheepManager>();
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
                sheep.SetDestination(placementData.Position);
                sheep.transform.parent = transform;
                placementData.isOcuppied = true;
                placementData.Sheep=sheep;
            }
        }
    }

    public void removeSheep(SheepBehaviour sheep) 
    {
        foreach(SheepPlacementData data in positions) 
        {
            if (data.Sheep == sheep) 
            {
                data.isOcuppied = false;
                data.Sheep=null;
            }
        }
    }
}
