using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    const string WorldHubLevel = "Mundos";
    const string BackLevel = "Pant2";
    const string Credits = "Creditos";
    //const string LogIn = "Log In";
    const string SignUp = "SignUp";

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void ComenzarJuegos()
    {
        ChangeScene(SignUp);
    }

    public void VueltaAlMenu()
    {
        ChangeScene(BackLevel);
    }

    public void Creditos()
    {
        ChangeScene(Credits);
    }

    public void M1Nivel1()
    {

    }

    public void M1Nivel2()
    {

    }

    public void M1Nivel3()
    {

    }

    public void M2Nivel1()
    {

    }

    public void M2Nivel2()
    {

    }

    public void M2Nivel3()
    {

    }

}
