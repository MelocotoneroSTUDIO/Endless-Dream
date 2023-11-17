using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera mainCamera;
    public float velocidadRotacion = 5.0f;
    private Quaternion rotation;

    private void Start()
    {
        rotation = mainCamera.transform.rotation;
    }

    public void RotateCamera(float degrees)
    {
        rotation *= Quaternion.Euler(0f, degrees, 0f);
    }

    private void Update()
    {
        // Realizar una interpolación suave hacia la rotación deseada
        mainCamera.transform.rotation = Quaternion.Lerp(mainCamera.transform.rotation, rotation, Time.deltaTime * velocidadRotacion);
    }
}
