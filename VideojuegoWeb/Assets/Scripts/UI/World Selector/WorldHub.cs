using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldHub : MonoBehaviour
{

    [SerializeField] Button backButton;
    [SerializeField] Button optionButton;
    [SerializeField] CinemachineVirtualCamera selectorCamera;

    WorldPreview[] WorldPreviews => FindObjectsByType<WorldPreview>(FindObjectsSortMode.None);

    private void Awake()
    {
        backButton.onClick.AddListener(StartSelectionMode);
        StartSelectionMode();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSelectionMode()
    {
        foreach(var camera in FindObjectsByType<CinemachineVirtualCamera>(FindObjectsSortMode.None))
        {
            camera.enabled = false;
        }

        foreach (var worldPreview in FindObjectsByType<WorldPreview>(FindObjectsSortMode.None))
        {
            worldPreview.Deselect();
            worldPreview.canBeSelected = true;
        }

        selectorCamera.enabled = true;
        backButton.gameObject.SetActive(false);
        optionButton.gameObject.SetActive(true);
    }


    public void StartPreviewMode()
    {
        backButton.gameObject.SetActive(true);
        optionButton.gameObject.SetActive(false);

        foreach (var worldPreview in FindObjectsByType<WorldPreview>(FindObjectsSortMode.None))
        {   
            worldPreview.canBeSelected = false;
        }
    }

    
}
