using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.EventSystems;

public class CameraMovement : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [Header("Camera")]
    public CinemachineVirtualCamera VirtualCamera;
    private CinemachineOrbitalTransposer transposer;

    [Header("Camera stats")]
    public float speed;
    public float swipeThreshold;

    private bool draggingStarted = false;
    private Vector2 startPos, endPos;

    void Start()
    {
        transposer = VirtualCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>();
        speed = OptionsSaver.Options.cameraSensitivity;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("BBBBBBBBBBB");
        if (draggingStarted) 
        {
            endPos = eventData.position;
            Vector2 difference = endPos - startPos;

            if (difference.magnitude > swipeThreshold)
            {
                Debug.Log("AAAAAAA");
                transposer.m_XAxis.Value = transposer.m_XAxis.Value + (difference.x * speed) * Time.deltaTime;
            }

        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        draggingStarted = true;
        startPos = eventData.pressPosition;
        Debug.Log("CCCCCCCCCC");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        draggingStarted = false;
    }
}
