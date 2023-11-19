using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class BtwScenesMusic : MonoBehaviour
{
    private static BtwScenesMusic instance;
    private AudioSource audioSource;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        audioSource = GetComponent<AudioSource>();
        audioSource.playOnAwake = true; // Desactivar la reproducción automática
        audioSource.loop = true; // Para reproducir en bucle
        audioSource.Play(); // Para iniciar la reproducción
    }

    public void Stop()
    {
        audioSource.Stop();
    }
}

/*public class BtwScenesMusic : MonoBehaviour
{
    
    private static BtwScenesMusic instance;
    private AudioSource audioSource;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
    }
    void Start()
    {
        audioSource.playOnAwake = true;
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true; // Para reproducir en bucle
        audioSource.Play(); // Para iniciar la reproducción
        //DontDestroyOnLoad(gameObject); // Evita que el objeto se destruya al cambiar de escena

    }
    public void Stop(){
        audioSource.Stop();
    }
    /*void Update()
     {
         if (variousScenes) {
             audioSource.Stop(); // Para detener la reproducción
         }
     }
}*/

