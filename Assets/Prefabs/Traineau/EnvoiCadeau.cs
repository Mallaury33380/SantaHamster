using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvoiCadeau : MonoBehaviour
{
    [SerializeField] private GameObject cadeau;
    [SerializeField] private GameObject boule;

    [SerializeField] private float forceXTir2;
    [SerializeField] private float forceYTir2;

    [SerializeField] private float forceYTir1;
    [SerializeField] private float forceZTir1;

    public AudioSource Lancer;


    private string Tir2;
    private string Tir1;

    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Tir1 = PlayerPrefs.GetString("Tir1");
        Tir2 = PlayerPrefs.GetString("Tir2");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(Tir2))
        {
            float margex = -0.1f;
            float margey = -0.1f;
            Vector3 position = new Vector3(transform.position.x + margex, transform.position.y+margey, transform.position.z) ;
            Quaternion rotation = Quaternion.identity;

            GameObject newCadeau = Instantiate<GameObject>(cadeau, position, rotation);
            newCadeau.GetComponent<Rigidbody>().AddForce(transform.right * forceXTir2+ transform.up * forceYTir2);

            if (!Lancer.isPlaying)
            {
                Lancer.Play();
            }
        }

        if (Input.GetKeyDown(Tir1))
        {
            float margex = -0.1f;
            float margey = -0.1f;
            Vector3 position = new Vector3(transform.position.x + margex, transform.position.y + margey, transform.position.z);
            Quaternion rotation = Quaternion.identity;

            GameObject newboule = Instantiate<GameObject>(boule, position, rotation);
            newboule.GetComponent<Rigidbody>().AddForce(transform.forward * forceZTir1 + transform.up * forceYTir1);
            if (!Lancer.isPlaying)
            {
                Lancer.Play();
            }
        }
    }
}
