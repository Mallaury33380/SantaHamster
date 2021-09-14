using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getKeys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!(PlayerPrefs.HasKey("Avancer")))
        {
            PlayerPrefs.SetString("Avancer","z");
            PlayerPrefs.SetString("Reculer","s");
            PlayerPrefs.SetString("Gauche","q");
            PlayerPrefs.SetString("Droite","d");
            PlayerPrefs.SetString("Frein","c");
            PlayerPrefs.SetString("Tir1","mouse 0");
            PlayerPrefs.SetString("Tir2","e");
        }
    }  
}
