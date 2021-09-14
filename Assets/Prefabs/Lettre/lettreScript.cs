using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lettreScript : MonoBehaviour
{
    public int valPoints;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetFloat("Score", PlayerPrefs.GetFloat("Score") + valPoints);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerPrefs.GetInt("Tour") != 0)
        {
            Destroy(gameObject);
        }
    }
}
