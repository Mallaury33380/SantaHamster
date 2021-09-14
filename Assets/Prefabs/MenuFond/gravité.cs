using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravité : MonoBehaviour
{

    public AudioSource impact;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, -0.5F, 0);
    }

    public void OnTriggerEnter()
    {
        impact.Play();
    }

    
}
