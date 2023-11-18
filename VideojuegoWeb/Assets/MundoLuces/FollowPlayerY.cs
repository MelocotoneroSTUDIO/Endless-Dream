using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerY : MonoBehaviour
{
    public Transform playerPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerY = playerPos.position.y;
        transform.position = new Vector3(0, playerY+10, 0);
    }
}
