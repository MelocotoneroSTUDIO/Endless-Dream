using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSound : MonoBehaviour
{
    // Start is called before the first frame update
 void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.loop = true; // Para reproducir en bucle
        audioSource.Play(); // Para iniciar la reproducción
    }
}
