using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeInScene : MonoBehaviour
{
    private CanvasGroup pant1;
    public float fadeTime;

    private void Start()
    {
        pant1 = GetComponent<CanvasGroup>();
        pant1.alpha = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if(pant1.alpha > 0)
        {
            pant1.alpha -= fadeTime * Time.deltaTime;
        }
    }
}
