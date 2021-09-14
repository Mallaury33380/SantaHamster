using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gestionMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
