using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class affichageLeaderBoard : MonoBehaviour
{
    public Text titre;
    public Text contenu;
    public int numeroNiveau;
    // Start is called before the first frame update
    void Start()
    {
        titre.text = "Niveau " + numeroNiveau.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        contenu.text = "Record  " + PlayerPrefs.GetFloat("ScoreMax" + numeroNiveau.ToString())+"\n";
        for (int i = 1; i <= 10; i++)
        {
            if(PlayerPrefs.HasKey(numeroNiveau.ToString() + i.ToString()))
            {
                contenu.text += i.ToString() + ". " + PlayerPrefs.GetFloat(numeroNiveau.ToString() + i.ToString()) + "\n";
            }
            else
            {
                contenu.text += i.ToString() + ". "+ "\n";
            }
            
        }
        
    }
}
