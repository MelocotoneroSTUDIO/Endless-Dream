using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SheepSpawner : InteractableObject
{
    [Header("Sheep spawning")]
    public float spawnCooldown;
    public Transform spawnPosition;
    public Transform exitDoorPosition;
    public GameObject sheep;

    [Header("Door opening")]
    public GameObject door;
    public Vector3 doorOpenRotation;
    public float openTime;


    private bool allowSpawn=true;
    private Vector3 startRot;
    private SheepManager sheepManager;

    private void Start()
    {
        startRot = transform.rotation.eulerAngles;
        sheepManager = FindObjectOfType<SheepManager>();
    }

    public override void Interact()
    {
        //On door tocuh spawn sheep
        base.Interact();
        if (allowSpawn) 
        {
            allowSpawn = false;
            GameObject instance;
            instance = Instantiate(sheep,spawnPosition.position,spawnPosition.rotation);
            openDoor();
            SheepBehaviour sheepBehaviour = instance.GetComponent<SheepBehaviour>();
            sheepBehaviour.playerFollow = sheepManager.playerFollow;
            sheepManager.addSheep(sheepBehaviour);
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
        door.transform.DORotate(doorOpenRotation, openTime).OnComplete(() => { door.transform.DORotate(startRot, openTime); });
    }
}
