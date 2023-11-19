using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SignUpName : MonoBehaviour
{
    public GameObject login;
    public GameObject currentUI;
    public GameObject nextUI;

    public InputField emailInput;
    public InputField passwordInput;

    public Button goToNextButton;
    public Button goToPreviousButton;

    public List<Button> logInButton;

    // Start is called before the first frame update
    void Start()
    {
        currentUI.SetActive(true); // Asegúrate de que el NameUI esté activo al inicio
        nextUI.SetActive(false);

        //registerButton.onClick.AddListener(writeStuffToFile);
        goToNextButton.onClick.AddListener(goToNextStep);
        goToNextButton.onClick.AddListener(writeStuffToFile);
        //goToPreviousButton.onClick.AddListener(goToPreviousScene);

        foreach (var button in logInButton) button.onClick.AddListener(goToLogIn);

    }

    void goToNextStep()
    {
        currentUI.SetActive(false); // Oculta el NameUI al presionar "Siguiente"
        nextUI.SetActive(true); // Muestra el GenreUI al presionar "Siguiente"
    }
    //public void goToPreviousScene()
    //{
    //    SceneManager.LoadScene("Log In");
    //}

    void goToLogIn()
    {
        currentUI.SetActive(false);
        login.SetActive(true);
    }

    void writeStuffToFile()
    {
        Debug.Log("email y contraseña asignados.");
        // Asigna los valores al controlador central
        SaveSystem.save.email = emailInput.text;
        SaveSystem.save.password = passwordInput.text;
    }
}