using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Playables;

public class CameraSwitch : MonoBehaviour
{
    public CinemachineVirtualCamera vCam1;
    public CinemachineVirtualCamera vCam2;
    public PlayableDirector director;

    public void ChangeCamera() 
    {
        vCam1.Priority = 0;
        vCam2.Priority = 1;
        director.Play(); //Just some testing, needs own sequence controller script that starts the camera dolly and changes camera to main cam at the end
    }
}
