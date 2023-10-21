using Cinemachine;
using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityButtonBehaviour : MonoBehaviour
{
    private static bool isActive=false;
    public float cameraYOffset;
    CinemachineBrain cinemachineBrain;
    CinemachineVirtualCamera virtualCamera;
    CinemachineOrbitalTransposer transposer;
    // Start is called before the first frame update
    void Start()
    {
        cinemachineBrain = FindObjectOfType<CinemachineBrain>();
        virtualCamera = (CinemachineVirtualCamera)cinemachineBrain.ActiveVirtualCamera;
        transposer= virtualCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") 
        {
            other.GetComponent<PlayerMovement>().ChangeGravity();
            if (!isActive) 
            {
                Debug.Log("Baja camara");
                DOVirtual.Float(transposer.m_FollowOffset.y, transposer.m_FollowOffset.y - cameraYOffset,1,SetCameraOffset);
                isActive = true;
            }
            else 
            {
                Debug.Log("Sube camara");
                DOVirtual.Float(transposer.m_FollowOffset.y, transposer.m_FollowOffset.y + cameraYOffset, 1, SetCameraOffset);
                isActive = false;
            }
            
        }
    }

    public void SetCameraOffset(float y) 
    {
        transposer.m_FollowOffset = new Vector3(transposer.m_FollowOffset.x,y,transposer.m_FollowOffset.z);
    }
}
