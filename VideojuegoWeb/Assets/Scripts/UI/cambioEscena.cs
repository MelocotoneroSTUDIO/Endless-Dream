using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameObject.active == true) { SceneManager.LoadScene("SignUp"); }
       
    }

    void OnEnabled()
    {
        Debug.Log("Activado");
        SceneManager.LoadScene("SignUp");
    }
}
