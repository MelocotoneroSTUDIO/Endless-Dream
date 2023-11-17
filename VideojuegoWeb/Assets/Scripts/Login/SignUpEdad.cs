using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SignUpEdad : MonoBehaviour
{
    public Button increaseButton;
    public Button decreaseButton;
    //public Button acceptButton;
    public Button goToNextButton;
    public Button goToPreviousButton;
    //public Camera mainCamera;
    public CameraController cameraController;
    //ArrayList credentials;
    // Start is called before the first frame update
    void Start()
    {
        increaseButton.onClick.AddListener(adderPlus);
        decreaseButton.onClick.AddListener(adderLess);
        //acceptButton.onClick.AddListener(writeStuffToFile);
        goToNextButton.onClick.AddListener(goToNextScene);
        goToNextButton.onClick.AddListener(writeStuffToFile);
        goToPreviousButton.onClick.AddListener(goToPreviousStep);

    }
    void adderPlus(){
        PlayerDataController.instance.age += 1;
    }
        void adderLess(){
        PlayerDataController.instance.age -= 1;
    }
    void goToNextScene()
    {
        //mainCamera.transform.Rotate(0f, 90f, 0f);
        //rotation *= Quaternion.Euler(0f, 90f, 0f);
        SceneManager.LoadScene("Mundos");
    }
        void goToPreviousStep()
    {
        cameraController.RotateCamera(-90f);
        
    }
    void writeStuffToFile()
    {
        PlayerDataController.instance.SavePlayerData();
        Debug.Log("Todo guardado correctamente.");
    }
   /*     private void Update()
    {
        // Realizar una interpolación suave hacia la rotación deseada
        //mainCamera.transform.rotation = Quaternion.Lerp(mainCamera.transform.rotation, rotation, Time.deltaTime * velocityCamera);
    }
*/
}