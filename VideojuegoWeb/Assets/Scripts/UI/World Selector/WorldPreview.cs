using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldPreview : MonoBehaviour
{

    Rotation WorldRotation => FindAnyObjectByType<Rotation>();

    WorldPreview[] WorldPreviews => FindObjectsByType<WorldPreview>(FindObjectsSortMode.None);

    [SerializeField] CinemachineVirtualCamera worldCamera;
    [SerializeField] CinemachineVirtualCamera zoomCamera;



    [SerializeField] float angle;

    [SerializeField] Canvas canvas;

    public bool selected;

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
        canvas.gameObject.SetActive(true); 
    }


    public void Click()
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

    public void Deselect()
    {
        selected = false;
        canvas.gameObject.SetActive(false);
    }

}
