using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SignUpGenre : MonoBehaviour
{

    public InputField usernameInput;
    public Button maleButton;
    public Button femaleButton;
    public Button goToNextButton;
    public Button goToPreviousButton;
    public CameraController cameraController;

    //ArrayList credentials;
    //public float velocityCamera = 5.0f;
    //private Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        maleButton.onClick.AddListener(writeMaleToFile);
        femaleButton.onClick.AddListener(writeFemaleToFile);
        goToPreviousButton.onClick.AddListener(goToPreviousStep);
        goToNextButton.onClick.AddListener(goToNextStep);
        goToNextButton.onClick.AddListener(writeStuffToFile);
    }

    void goToNextStep()
    {
        //mainCamera.transform.Rotate(0f, 90f, 0f);
        //rotation *= Quaternion.Euler(0f, 90f, 0f);
        cameraController.RotateCamera(90f);
    }
        void goToPreviousStep()
    {
            cameraController.RotateCamera(-90f);

        //mainCamera.transform.Rotate(0f, 90f, 0f);
        //rotation *= Quaternion.Euler(0f, 0f, 0f);
    }
    void writeStuffToFile(){
        PlayerDataController.instance.username=usernameInput.text;
        Debug.Log("Nombre asignado");
    }
    void writeMaleToFile()
    {
        PlayerDataController.instance.gender="Hombre";
        Debug.Log("Hombre asignado");
    }
        void writeFemaleToFile()
    {
        PlayerDataController.instance.gender="Mujer";
        Debug.Log("Mujer asignada");
    }
    /*    private void Update()
    {
        // Realizar una interpolación suave hacia la rotación deseada
        //mainCamera.transform.rotation = Quaternion.Lerp(mainCamera.transform.rotation, rotation, Time.deltaTime * velocityCamera);
    }*/

}