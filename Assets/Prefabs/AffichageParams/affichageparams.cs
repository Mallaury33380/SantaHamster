using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class affichageparams : MonoBehaviour
{
    public Text Niveau;
    public Text Temps;
    public Text Score;
    public Text Vitesse;
    public Text Tours;

    public 
    // Start is called before the first frame update
    void Start()
    {
        Niveau.text += PlayerPrefs.GetInt("Niveau");
    }

    // Update is called once per frame
    void Update()
    {
        Temps.text = "1. " + PlayerPrefs.GetFloat("T1").ToString() + "\n2. " + PlayerPrefs.GetFloat("T2").ToString() + "\n3. " + PlayerPrefs.GetFloat("T3").ToString();

        Score.text= "Score "+PlayerPrefs.GetFloat("Score").ToString();

        Vitesse.text = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<Rigidbody>().velocity.magnitude.ToString("F2");
        Tours.text = PlayerPrefs.GetInt("Tour")+1 + "/3";

    }
}
