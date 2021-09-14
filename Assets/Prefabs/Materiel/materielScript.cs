using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materielScript : MonoBehaviour
{
    public GameObject materiel;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Tour") == 1)
        {
            materiel.SetActive(true);
        }
        else
        {
            materiel.SetActive(false);
        }
    }
}
