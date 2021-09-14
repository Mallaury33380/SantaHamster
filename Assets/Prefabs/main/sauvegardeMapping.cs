using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sauvegardeMapping : MonoBehaviour
{
    public Text Avancer;
    public Text Reculer;
    public Text Gauche;
    public Text Droite;
    public Text Frein;
    public Text Tir1;
    public Text Tir2;

    public void sauvegarde()
    {
        string avancer = Avancer.text;
        if (avancer != "")
        {
            PlayerPrefs.SetString("Avancer", avancer);
        }
        else
        {
            PlayerPrefs.SetString("Avancer", "z");
        }

        string reculer = Reculer.text;
        if (reculer != "")
        {
            PlayerPrefs.SetString("Reculer", reculer);
        }
        else
        {
            PlayerPrefs.SetString("Reculer", "s");
        }

        string gauche = Gauche.text;
        if (gauche != "")
        {
            PlayerPrefs.SetString("Gauche", gauche);
        }
        else
        {
            PlayerPrefs.SetString("Gauche", "q");
        }

        string droite = Droite.text;
        if (droite != "")
        {
            PlayerPrefs.SetString("Droite", droite);
        }
        else
        {
            PlayerPrefs.SetString("Droite", "d");
        }

        string frein = Frein.text;
        if (frein != "")
        {
            PlayerPrefs.SetString("Frein", frein);
        }
        else
        {
            PlayerPrefs.SetString("Frein", "c");
        }

        string tir1 = Tir1.text;
        if (tir1 != "")
        {
            PlayerPrefs.SetString("Tir1", tir1);
        }
        else
        {
            PlayerPrefs.SetString("Tir1", "mouse 0");
        }

        string tir2 = Tir2.text;
        if (tir2 != "")
        {
            PlayerPrefs.SetString("Tir2", tir2);
        }
        else
        {
            PlayerPrefs.SetString("Tir2", "e");
        }
    }
}
