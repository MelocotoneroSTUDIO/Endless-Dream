using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI volumenText;
    [SerializeField] Button volumeUp;
    [SerializeField] Button volumeDown;
    [SerializeField] AudioMixer audioMixer;
    int currentVolume;
    

    private void Awake()
    {
        currentVolume = 0;
        ChangeVolume(5);
        
        volumeUp.onClick.AddListener(() => ChangeVolume(1));
        volumeDown.onClick.AddListener(() => ChangeVolume(-1));

        Hide();
    }

    void ChangeVolume(int volumen)
    {
        currentVolume += volumen;
        if(currentVolume < 0)
        {
            currentVolume = 0;
        }

        if (currentVolume > 10)
        {
            currentVolume = 10;
        }

        volumenText.text = currentVolume.ToString();

        audioMixer.SetFloat("MasterVolume", Mathf.Log10(currentVolume)*20);

    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
