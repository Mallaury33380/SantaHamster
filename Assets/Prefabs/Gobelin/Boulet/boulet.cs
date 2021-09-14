using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulet : MonoBehaviour
{
    public float value;


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerPrefs.SetFloat("Score", PlayerPrefs.GetFloat("Score") - value);
            Destroy(gameObject);
        }
    } 
}
