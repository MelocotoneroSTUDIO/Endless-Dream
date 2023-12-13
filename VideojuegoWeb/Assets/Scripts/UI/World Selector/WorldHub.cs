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

    WorldPreview[] WorldPreviews => FindObjectsByType<WorldPreview>(FindObjectsSortMode.InstanceID);



    private void Awake()
    {
        backButton.onClick.AddListener(StartSelectionMode);
        StartSelectionMode();

        var levels = GetLevels();


        Debug.Log("World previews: " + WorldPreviews[1]);
        Debug.Log("Completed levels = " + SaveSystem.save.completedLevels);
        Debug.Log("Levels: " + levels);

        for (int i = 0 ; i < SaveSystem.save.completedLevels; i++)
        {
            levels[i].locked = false;
            levels[i].unlockLevel();
        }
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

    public WorldPreview.Level[] GetLevels()
    {
        List<WorldPreview.Level> levels = new List<WorldPreview.Level>();
        List<WorldPreview> worlds = new List<WorldPreview>();
        worlds.AddRange(WorldPreviews);
        worlds.Sort((a,b) => a.gameObject.name.CompareTo(b.gameObject.name));
        foreach(var p in worlds)
        {
            levels.AddRange(p.levels);
        }

        return levels.ToArray();
    }
    
}
