using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SignUpEdad : MonoBehaviour
{
    public GameObject logIn;
    public GameObject signUp;
    public GameObject previousUI;

    public Button increaseButton;
    public Button decreaseButton;
    //public Button acceptButton;
    public Button goToNextButton;
    public Button goToPreviousButton;

    public Button login;
    public Button signup;

    public TextMeshProUGUI ageDisplay;
    //public Camera mainCamera;
    
    //ArrayList credentials;
    // Start is called before the first frame update
    void Start()
    {
        ageDisplay.text = SaveSystem.save.age.ToString();

        increaseButton.onClick.AddListener(adderPlus);
        decreaseButton.onClick.AddListener(adderLess);

        goToNextButton.onClick.AddListener(goToNextScene);
        goToNextButton.onClick.AddListener(writeStuffToFile);
        goToPreviousButton.onClick.AddListener(goToPreviousStep);

        login.onClick.AddListener(goTologIn);
        signup.onClick.AddListener(goToSignUp);
    }

    void adderPlus()
    {
        SaveSystem.save.age += 1;
        ageDisplay.text = SaveSystem.save.age.ToString();
    }
    void adderLess()
    {
        SaveSystem.save.age -= 1;
        if (SaveSystem.save.age < 0) 
        {
            SaveSystem.save.age = 0;
        }
        ageDisplay.text = SaveSystem.save.age.ToString();
    }
    void goToNextScene()
    {
        SceneManager.LoadScene("Mundos");
    }
    void goToPreviousStep()
    {
        gameObject.SetActive(false);
        previousUI.SetActive(true);
    }
    void writeStuffToFile()
    {
        SaveSystem.SaveData();
        Debug.Log("Todo guardado correctamente.");
    }

    void goTologIn()
    {
        gameObject.SetActive(false);
        logIn.SetActive(true);
    }
    void goToSignUp()
    {
        gameObject.SetActive(false);
        signUp.SetActive(true);
    }
}