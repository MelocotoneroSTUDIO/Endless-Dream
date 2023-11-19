using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class UIClickSoundButton : MonoBehaviour
{
    private Button button;
    public AudioClip soundClip; // AudioClip asignado desde el inspector

    private SoundManager soundManager;

    private void Start()
    {
        button = GetComponent<Button>();
        soundManager = FindObjectOfType<SoundManager>();

        if (soundManager == null)
        {
            Debug.LogError("No se encontró el SoundManager en la escena.");
            return;
        }

        button.onClick.AddListener(PlaySound);
    }

    private void PlaySound()
    {
        soundManager.PlayButtonSound(soundClip);
    }
}



