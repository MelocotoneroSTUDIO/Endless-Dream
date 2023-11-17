using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    const string WorldHubLevel = "Mundos";
    const string BackLevel = "Pant2";
    const string Credits = "Creditos";

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
        ChangeScene(WorldHubLevel);
    }

    public void VueltaAlMenu()
    {
        ChangeScene(BackLevel);
    }

    public void Creditos()
    {
        ChangeScene(Credits);
    }

}
