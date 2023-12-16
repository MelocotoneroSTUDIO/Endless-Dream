using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public GameObject currentUI;
    public GameObject nextUI;

    //public InputField emailInput;
    //public InputField passwordInput;

    //public Button goToNextButton;
    //public Button goToPreviousButton;

    public InputField usernameInput;
    public InputField passwordInput;
    public List<Button> loginButton;
    public List<Button> goToRegisterButton;

    public DatabaseManager databaseManager;

    // Start is called before the first frame update
    void Start()
    {
        currentUI.SetActive(true); // Asegúrate de que el NameUI esté activo al inicio
        nextUI.SetActive(false);

        foreach (Button button in loginButton) button.onClick.AddListener(login);
        foreach (Button button in goToRegisterButton) button.onClick.AddListener(moveToSignUp);

    }

    void moveToSignUp()
    {
        currentUI.SetActive(false); // Oculta el NameUI al presionar "Siguiente"
        nextUI.SetActive(true); // Muestra el GenreUI al presionar "Siguiente"
    }
    public void goToPreviousScene()
    {
        SceneManager.LoadScene("WelcomeScreen");
    }



    public void login()
    {
        string mail = usernameInput.text;
        string password = passwordInput.text;

        databaseManager.LoadGame(mail,password);

        //SceneManager.LoadScene("Mundos");
    }

    


    //void loadWelcomeScreen()
    //{
    //    SceneManager.LoadScene("WelcomeScreen");
    //}
}
