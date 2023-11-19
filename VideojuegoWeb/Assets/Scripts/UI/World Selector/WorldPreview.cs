using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class WorldPreview : MonoBehaviour
{

    Rotation WorldRotation => FindAnyObjectByType<Rotation>();

    [SerializeField] public Level[] levels;

    WorldPreview[] WorldPreviews => FindObjectsByType<WorldPreview>(FindObjectsSortMode.None);

    [SerializeField] CinemachineVirtualCamera worldCamera;
    [SerializeField] CinemachineVirtualCamera zoomCamera;

    [SerializeField] TextMeshPro titulo1;
    [SerializeField] TextMeshPro titulo2;
    [SerializeField] TextMeshPro titulo3;
    [SerializeField] TextMeshPro titulo4;


    [SerializeField] float angle;

    [SerializeField] Canvas canvas;

    public bool selected;
    public bool canBeSelected;

    [SerializeField] bool startAsSelected;

    [SerializeField] Color lockedColor;

    WorldHub WorldHub => FindAnyObjectByType<WorldHub>();


    private void Start()
    {
        if(startAsSelected)
        {
            selected = true;
        }
        canBeSelected = true;

        foreach(var level in levels)
        {
            level.Initialize(FindAnyObjectByType<SceneChanger>(), lockedColor);
        }

    }

    private void Awake()
    {
        
    }

    private void OnMouseDown()
    {
        Click();
    }

    [ContextMenu("Select For Preview")]
    void SelectForPreview()
    {
        canvas.gameObject.SetActive(false);

        

        WorldRotation.SetRotation(angle);

        foreach (var r in WorldPreviews)
        {
            r.Deselect();
        }

        selected = true;
        
        worldCamera.enabled = true;

    }

    [ContextMenu("Select For Level Selection")]
    void SelectForLevelSelection()
    {
        
        worldCamera.enabled = false;
        zoomCamera.enabled = true;
        WorldHub.StartPreviewMode();
        canvas.gameObject.SetActive(true);

        titulo1.gameObject.SetActive(false);
        titulo2.gameObject.SetActive(false);
        titulo3.gameObject.SetActive(false);
        titulo4.gameObject.SetActive(false);
    }


    public void Click()
    {
        if(canBeSelected)
        {
            if (selected)
            {
                SelectForLevelSelection();

            }
            else
            {
                SelectForPreview();
            }
        }
        
    }

    public void Deselect()
    {
        selected = false;
        canvas.gameObject.SetActive(false);

        titulo1.gameObject.SetActive(true);
        titulo2.gameObject.SetActive(true);
        titulo3.gameObject.SetActive(true);
        titulo4.gameObject.SetActive(true);
    }



    [Serializable]
    public class Level
    {
        public bool locked;
        public string sceneName;
        public Button button;
        public Image lockImage;

        public void Initialize(SceneChanger sceneChanger, Color lockedColor)
        {
            if (locked)
            {
               button.enabled = false;
                button.image.color = lockedColor;
                lockImage.enabled = true;
            }
            else
            {
                button.onClick.AddListener(() => sceneChanger.ChangeScene(sceneName));
                lockImage.enabled = false;
            }

        }
    }



}
