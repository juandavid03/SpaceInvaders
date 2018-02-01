﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.K) && SceneManager.GetActiveScene().name == "Tutorial")
        {
            LoadScene("Nivel1");
        }
    }
    public void LoadScene(string nextScene)
    {
        SceneManager.LoadScene(nextScene);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
