using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SignUpGenre : MonoBehaviour
{

    public GameObject previousUI;
    public GameObject nextUI;

    public InputField usernameInput;
    public Button maleButton;
    public Button femaleButton;
    public Button goToNextButton;
    public Button goToPreviousButton;

    //ArrayList credentials;
    //public float velocityCamera = 5.0f;
    //private Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        nextUI.SetActive(false);

        maleButton.onClick.AddListener(writeMaleToFile);
        femaleButton.onClick.AddListener(writeFemaleToFile);
        goToPreviousButton.onClick.AddListener(goToPreviousStep);
        goToNextButton.onClick.AddListener(goToNextStep);
        goToNextButton.onClick.AddListener(writeStuffToFile);
    }

    void goToNextStep()
    {
        gameObject.SetActive(false); // Oculta el NameUI al presionar "Siguiente"
        nextUI.SetActive(true); // Muestra el GenreUI al presionar "Siguiente"
    }

    void goToPreviousStep()
    {
        gameObject.SetActive(false);
        previousUI.SetActive(true);
    }
    void writeStuffToFile(){
        SaveSystem.save.username = usernameInput.text;
        Debug.Log("Nombre asignado");
    }
    void writeMaleToFile()
    {
        SaveSystem.save.gender="Hombre";
        maleButton.image.color = Color.gray;
        femaleButton.image.color = Color.white;
        Debug.Log("Hombre asignado");
    }
    void writeFemaleToFile()
    {
        SaveSystem.save.gender="Mujer";
        maleButton.image.color = Color.white;
        femaleButton.image.color = Color.gray;
        Debug.Log("Mujer asignada");
    }

}