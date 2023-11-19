using System;
using UnityEngine;

public class PlayerDataController : MonoBehaviour
{
    public static PlayerDataController instance; // Singleton instance

    // Datos del jugador
    public string email;
    public string password;
    public string username;
    public string gender;
    public int age;

    private void Awake()
    {
        // Implementación del Singleton
        if (instance == null)
        {
            Debug.Log("Se ha creado correctamente la instancia del PlayerDatacOntroller.");
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SavePlayerData()
    {
        SaveInfo save = new SaveInfo
        {
            email = email,
            password = password,
            username = username,
            gender = gender,
            age = age
            // Añade más campos según sea necesario
        };
        // Asigna la información al SaveSystem
        SaveSystem.save = save;
        SaveSystem.SaveData();
    }
}
