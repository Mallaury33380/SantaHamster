using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gestionMenuInGame : MonoBehaviour
{
    private bool afficher = false;
    public GameObject main;
    public GameObject options;
    public GameObject aide;
    public void Update()
    {
        if (Input.GetKeyDown("escape") && !options.active && !aide.active)
        {
            afficher = !afficher;
            main.SetActive(afficher);
        }
    }

    public void playGame()
    {
        main.gameObject.SetActive(false);
        afficher = false;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
