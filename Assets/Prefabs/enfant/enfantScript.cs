using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enfantScript : MonoBehaviour
{
    public GameObject enfant;
   

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("Tour") == 2)
        {
            enfant.SetActive(true);
        }
        else
        {
            enfant.SetActive(false);
        }
    }
}
