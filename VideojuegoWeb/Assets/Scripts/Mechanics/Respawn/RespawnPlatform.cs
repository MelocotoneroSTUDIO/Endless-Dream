using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlatform : MonoBehaviour
{
    public Transform respawnPosition;
    public PlayerMovement player;

    private EventSystem eventSystem;
    // Start is called before the first frame update
    void Start()
    {
        eventSystem = FindObjectOfType<EventSystem>();
        eventSystem.OnHit += Respawn;
    }

    public void Respawn() 
    {
        player.blockPlayerMovement = true;
        player.gravity = 0;
        player.transform.position = respawnPosition.position;
        player.transform.rotation = Quaternion.Slerp(player.transform.rotation, respawnPosition.rotation, 1f);
        StartCoroutine(DisableBlockPlayerMovement());
    }

    IEnumerator DisableBlockPlayerMovement() 
    {
        yield return new WaitForSeconds(1f);
        player.blockPlayerMovement = false;
    }


}
