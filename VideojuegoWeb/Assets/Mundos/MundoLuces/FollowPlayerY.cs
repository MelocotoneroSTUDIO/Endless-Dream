using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerY : MonoBehaviour
{
    public Transform playerPos;

    // Update is called once per frame
    void Update()
    {
        float playerY = playerPos.position.y;
        if(playerY < 80)
        {
            transform.position = new Vector3(0, playerY+30, 0);
        }
    }
}
