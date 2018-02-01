using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.K) && (SceneManager.GetActiveScene().name == "Tutorial" || SceneManager.GetActiveScene().name == "Highscore"))
        {
            LoadScene("Nivel1");
        }
        if (Input.GetKeyDown(KeyCode.Escape) && (SceneManager.GetActiveScene().name == "Tutorial" || SceneManager.GetActiveScene().name == "Highscore"))
        {
            LoadScene("MainMenu");
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
