using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldPreview : MonoBehaviour
{

    Rotation worldRotation => FindAnyObjectByType<Rotation>();

    [SerializeField] CinemachineVirtualCamera worldCamera;
    [SerializeField] CinemachineVirtualCamera zoomCamera;



    [SerializeField] float angle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Select For Preview")]
    void SelectForPreview()
    {
        worldRotation.SetRotation(angle);

    }

    [ContextMenu("Select For Level Selection")]
    void SelectForLevelSelection()
    {
        worldCamera.enabled = false;
        zoomCamera.enabled = true;
    }
}
