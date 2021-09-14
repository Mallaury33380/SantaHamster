using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hamstronaute : MonoBehaviour
{
    public AudioSource decollage;
    public float x;
    public float y;
    public float z;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            decollage.Play();
            other.gameObject.transform.position = new Vector3(x, y, z);
        }
    }
}
