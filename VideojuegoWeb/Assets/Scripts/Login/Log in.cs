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

    ArrayList credentials;

    // Start is called before the first frame update
    void Start()
    {
        currentUI.SetActive(true); // Asegúrate de que el NameUI esté activo al inicio
        nextUI.SetActive(false);

        //registerButton.onClick.AddListener(writeStuffToFile);
        //goToNextButton.onClick.AddListener(goToNextStep);
        //goToNextButton.onClick.AddListener(writeStuffToFile);
        //goToPreviousButton.onClick.AddListener(goToPreviousScene);

        foreach (Button button in loginButton) button.onClick.AddListener(login);
        foreach (Button button in goToRegisterButton) button.onClick.AddListener(moveToSignUp);
        //loginButton.onClick.AddListener(login);
        //goToRegisterButton.onClick.AddListener(moveToSignUp);

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
        /*bool isExists = false;

        credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));

        foreach (var i in credentials)
        {
            string line = i.ToString();
            //Debug.Log(line);
            //Debug.Log(line.Substring(11));
            //substring 0-indexof(:) - indexof(:)+1 - i.length-1
            if (i.ToString().Substring(0, i.ToString().IndexOf(":")).Equals(usernameInput.text) &&
                i.ToString().Substring(i.ToString().IndexOf(":") + 1).Equals(passwordInput.text))
            {
                isExists = true;
                break;
            }
        }

        if (isExists)
        {
            Debug.Log($"Logging in '{usernameInput.text}'");
            loadWelcomeScreen();
        }
        else
        {
            Debug.Log("Incorrect credentials");
        }*/
        SceneManager.LoadScene("Mundos");
    }


    //void loadWelcomeScreen()
    //{
    //    SceneManager.LoadScene("WelcomeScreen");
    //}
}
