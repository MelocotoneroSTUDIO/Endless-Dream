using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepManager : MonoBehaviour
{
    //Class that manages all sheeps in the level
    private List<SheepBehaviour> sheeps = new List<SheepBehaviour>();
    public Transform playerFollow;

    public SheepBehaviour getFollowSheep() 
    {
        foreach(SheepBehaviour sheep in sheeps) 
        {
            if (sheep.isFollowing) 
            {
                sheep.isFollowing = false;
                return sheep;
            }
        }
        return null;
    }


    public void addSheep(SheepBehaviour sheep) 
    {
        sheeps.Add(sheep);
    }

    public void removeSheep(SheepBehaviour sheep) 
    {
        sheeps.Remove(sheep);
    }
}
