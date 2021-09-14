using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactMateriel : MonoBehaviour
{
    public int valueScore;
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            PlayerPrefs.SetFloat("Score",PlayerPrefs.GetFloat("Score")+valueScore);
            Destroy(transform.parent.gameObject);
        }
    }
}
