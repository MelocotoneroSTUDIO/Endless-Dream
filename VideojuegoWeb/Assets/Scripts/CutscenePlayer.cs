using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CutscenePlayer : MonoBehaviour
{

    VideoPlayer Player => GetComponent<VideoPlayer>();
    SceneChanger sceneChanger => FindAnyObjectByType<SceneChanger>();

    // Start is called before the first frame update
    void Start()
    {
        Player.Play();
        Player.loopPointReached += (video)=> sceneChanger.ChangeScene("Pant1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
