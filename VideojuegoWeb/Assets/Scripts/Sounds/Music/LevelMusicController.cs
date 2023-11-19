using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMusicController : MonoBehaviour
{
    AudioSource audioSource;
    public bool variousScenes;

    void Start()
    {
        variousScenes=false;
        audioSource = GetComponentInChildren<AudioSource>();
        audioSource.loop = true; // Para reproducir en bucle
        audioSource.Play(); // Para iniciar la reproducción
        //DontDestroyOnLoad(gameObject); // Evita que el objeto se destruya al cambiar de escena

    }


    /*void Update()
     {
         if (variousScenes) {
             audioSource.Stop(); // Para detener la reproducción
         }
     }*/
}
