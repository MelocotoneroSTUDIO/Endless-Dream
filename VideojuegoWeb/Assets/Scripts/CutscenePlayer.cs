using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class CutscenePlayer : MonoBehaviour
{

    [SerializeField] string link;

    VideoPlayer Player => GetComponent<VideoPlayer>();

    // Start is called before the first frame update
    void Start()
    {
        Player.url = link;
        Player.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
