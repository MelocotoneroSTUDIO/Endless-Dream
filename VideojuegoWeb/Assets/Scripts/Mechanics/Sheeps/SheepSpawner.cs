using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SheepSpawner : InteractableObject
{
    public float spawnCooldown;
    public Transform spawnPosition;
    public Transform exitDoorPosition;
    public Transform playerFollow;
    public GameObject sheep;

    public GameObject door;
    public Vector3 doorOpenRot;
    public float openTime;
    private bool allowSpawn=true;
    private Vector3 startRot;

    private void Start()
    {
        startRot = transform.rotation.eulerAngles;
    }

    public override void Interact()
    {
        base.Interact();
        if (allowSpawn) 
        {
            allowSpawn = false;
            GameObject instance;
            instance = Instantiate(sheep,spawnPosition.position,spawnPosition.rotation);
            openDoor();
            SheepBehaviour sheepBehaviour = instance.GetComponent<SheepBehaviour>();
            sheepBehaviour.playerFollow = playerFollow;
            //sheepBehaviour.SetDestination(exitDoorPosition.position);
            instance.transform.DOMove(exitDoorPosition.position,2);
            StartCoroutine(cooldown());
        }
    }

    IEnumerator cooldown() 
    {
        yield return new WaitForSeconds(spawnCooldown);
        allowSpawn = true;
    }

    void openDoor() 
    {
        door.transform.DORotate(doorOpenRot, openTime).OnComplete(() => { door.transform.DORotate(startRot, openTime); });
    }
}
