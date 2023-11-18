using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMusicController : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true; // Para reproducir en bucle
        audioSource.Play(); // Para iniciar la reproducción
    }


    // void Update()
    // {
    //     if (/* condición para finalizar el nivel */) {
    //         audioSource.Stop(); // Para detener la reproducción
    //     }
    // }
}
