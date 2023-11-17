using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenu : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI volumenText;
    [SerializeField] Button volumeUp;
    [SerializeField] Button volumeDown;
    int currentVolume;


    private void Awake()
    {
        volumeUp.onClick.AddListener(() => ChangeVolume(1));
        volumeDown.onClick.AddListener(() => ChangeVolume(-1));
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
    }
}
