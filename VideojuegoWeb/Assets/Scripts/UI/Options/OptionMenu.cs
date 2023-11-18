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

    [SerializeField] TextMeshProUGUI sensitivityText;
    [SerializeField] Button sensitivityUp;
    [SerializeField] Button sensitivityDown;
    float currentSensitivity;



    private void Awake()
    {
        OptionsSaver.LoadOptions();
        currentVolume = 0;
        currentSensitivity = 0;
        ChangeVolume(OptionsSaver.Options.volume);
        ChangeSensitivity(OptionsSaver.Options.cameraSensitivity);
        
        volumeUp.onClick.AddListener(() => ChangeVolume(1));
        volumeDown.onClick.AddListener(() => ChangeVolume(-1));

        sensitivityUp.onClick.AddListener(() => ChangeSensitivity(1));
        sensitivityDown.onClick.AddListener(() => ChangeSensitivity(-1));

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

        OptionsSaver.Options.volume = currentVolume;
        volumenText.text = currentVolume.ToString();

        audioMixer.SetFloat("MasterVolume", Mathf.Log10(currentVolume)*20);


    }

    void ChangeSensitivity(float sensitivity)
    {
        currentSensitivity += sensitivity;
        if (currentSensitivity < 0)
        {
            currentSensitivity = 0;
        }

        if (currentSensitivity > 10)
        {
            currentSensitivity = 10;
        }

        sensitivityText.text = currentSensitivity.ToString();
        
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        OptionsSaver.SaveOptions();
        gameObject.SetActive(false);
    }
}
