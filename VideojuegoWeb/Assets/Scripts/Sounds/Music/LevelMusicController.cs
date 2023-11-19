using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMusicController : MonoBehaviour
{
    void Start()
    {
        AudioSource audioSource = GetComponentInChildren<AudioSource>();
        audioSource.loop = true; // Para reproducir en bucle
        CheckAndStopSoundManager();
        audioSource.Play(); // Para iniciar la reproducción
        
    }

    private void CheckAndStopSoundManager()
    {
        SoundManager soundManager = FindObjectOfType<SoundManager>();
        if (soundManager != null)
        {
            soundManager.Stop();
            Destroy(soundManager.gameObject);// Elimina el objeto BtwScenesMusic
        }
    }
}
