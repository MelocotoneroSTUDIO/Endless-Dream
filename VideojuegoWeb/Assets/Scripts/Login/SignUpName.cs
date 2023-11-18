using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SignUpName : MonoBehaviour
{
    public GameObject nameUI;
    public GameObject genreUI;
    public GameObject edadUI;
    public InputField emailInput;
    public InputField passwordInput;
    //public Button registerButton;
    public Button goToNextButton;
    public Button goToPreviousButton;
    //public Camera mainCamera;
    //public CameraController cameraController;
    //ArrayList credentials;
    // Start is called before the first frame update
    void Start()
    {
        nameUI.SetActive(true); // Asegúrate de que el NameUI esté activo al inicio
        genreUI.SetActive(false);
        edadUI.SetActive(false);

        //registerButton.onClick.AddListener(writeStuffToFile);
        goToNextButton.onClick.AddListener(goToNextStep);
        goToNextButton.onClick.AddListener(writeStuffToFile);
        goToPreviousButton.onClick.AddListener(goToPreviousScene);
        /*if(emailInput == null)
        {
        emailInput = GetComponentInChildren<InputField>(); // Ejemplo de inicialización
        }

        if(passwordInput == null)
        {
            passwordInput = GetComponentInChildren<InputField>(); // Ejemplo de inicialización
        }

          if (File.Exists(Application.dataPath + "/credentials.txt"))
        {
            credentials = new ArrayList(File.ReadAllLines(Application.dataPath + "/credentials.txt"));
        }
        else
        {
            File.WriteAllText(Application.dataPath + "/credentials.txt", "");
        }*/

    }

    void goToNextStep()
    {
        //mainCamera.transform.Rotate(0f, 90f, 0f);
        //rotation *= Quaternion.Euler(0f, 90f, 0f);
        //cameraController.RotateCamera(90f);
        nameUI.SetActive(false); // Oculta el NameUI al presionar "Siguiente"
        genreUI.SetActive(true); // Muestra el GenreUI al presionar "Siguiente"
    }
        void goToPreviousScene()
    {
        SceneManager.LoadScene("Log In");
    }


    void writeStuffToFile()
    {
        Debug.Log("email y contraseña asignados.");
        // Asigna los valores al controlador central
        PlayerDataController.instance.email = emailInput.text;
        PlayerDataController.instance.password = passwordInput.text;
    }
   /*     private void Update()
    {
        // Realizar una interpolación suave hacia la rotación deseada
        //mainCamera.transform.rotation = Quaternion.Lerp(mainCamera.transform.rotation, rotation, Time.deltaTime * velocityCamera);
    }
*/
}