using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPoints : MonoBehaviour
{
    public int numeroPoint;
    public bool Finish;
    public GameObject point;
    public int nombrePoint;

    public int nombreTour;

    private float TimeDebut;

    void Start()
    {
        PlayerPrefs.SetInt("Point", 0);
        PlayerPrefs.SetInt("Tour", 0);

        PlayerPrefs.SetInt("T1", 0);
        PlayerPrefs.SetInt("T2", 0);
        PlayerPrefs.SetInt("T3", 0);

        if (numeroPoint==0)
        {
            point.SetActive(true);
        }
        else
        {
            point.SetActive(false);
        }
        TimeDebut = Time.time;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (numeroPoint == PlayerPrefs.GetInt("Point"))
            {
                if (Finish)
                {
                    PlayerPrefs.SetInt("Tour", PlayerPrefs.GetInt("Tour") + 1);

                    PlayerPrefs.SetFloat("T" + PlayerPrefs.GetInt("Tour").ToString(), (Time.time - TimeDebut));

                    if (PlayerPrefs.GetInt("Tour") == nombreTour)
                    {
                        NewTime();
                        SceneManager.LoadScene("Lobby");
                    }
                }

                point.SetActive(false);

                PlayerPrefs.SetInt("Point", (PlayerPrefs.GetInt("Point") + 1));

                if (PlayerPrefs.GetInt("Point") == nombrePoint)
                {
                    PlayerPrefs.SetInt("Point", 0);
                }

            }
        }
    }

    public void Update()
    {
        if (numeroPoint == PlayerPrefs.GetInt("Point"))
        {
            point.SetActive(true);
        }
    }

    private void NewTime()
    {
        string niveau = (PlayerPrefs.GetInt("Niveau")).ToString();
        PlayerPrefs.SetFloat(niveau + "10", PlayerPrefs.GetFloat(niveau + "9"));
        PlayerPrefs.SetFloat(niveau + "9", PlayerPrefs.GetFloat(niveau + "8"));
        PlayerPrefs.SetFloat(niveau + "8", PlayerPrefs.GetFloat(niveau + "7"));
        PlayerPrefs.SetFloat(niveau + "7", PlayerPrefs.GetFloat(niveau + "6"));
        PlayerPrefs.SetFloat(niveau + "6", PlayerPrefs.GetFloat(niveau + "5"));
        PlayerPrefs.SetFloat(niveau + "5", PlayerPrefs.GetFloat(niveau + "4"));
        PlayerPrefs.SetFloat(niveau + "4", PlayerPrefs.GetFloat(niveau + "3"));
        PlayerPrefs.SetFloat(niveau + "3", PlayerPrefs.GetFloat(niveau + "2"));
        PlayerPrefs.SetFloat(niveau + "2", PlayerPrefs.GetFloat(niveau + "1"));
        PlayerPrefs.SetFloat(niveau + "1", Time.time-TimeDebut);

        float score = PlayerPrefs.GetFloat("Score");
        float Maxscore = PlayerPrefs.GetFloat("ScoreMax"+PlayerPrefs.GetInt("Niveau").ToString());

        if (score > Maxscore)
        {
            PlayerPrefs.SetFloat("ScoreMax" + PlayerPrefs.GetInt("Niveau").ToString(), score);
        }
    }
}
