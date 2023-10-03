using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepManager : MonoBehaviour
{
    private List<SheepBehaviour> sheeps = new List<SheepBehaviour>();

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
}
