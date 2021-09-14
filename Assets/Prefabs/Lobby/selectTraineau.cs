using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectTraineau : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject affiche;
    public int numeroTraineau;
    public AudioSource son;
    public int vitesse;

    void Start()
    {
        PlayerPrefs.SetInt("Traineau", 1);
        if (numeroTraineau == PlayerPrefs.GetInt("Traineau"))
        {
            affiche.SetActive(true);
        }
    }

    public void OnTriggerEnter()
    {
        PlayerPrefs.SetInt("Traineau", numeroTraineau);
        affiche.SetActive(true);
        son.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (numeroTraineau != PlayerPrefs.GetInt("Traineau"))
        {
            affiche.SetActive(false);
        }
        affiche.GetComponent<Rigidbody>().AddTorque(new Vector3(0, vitesse, 0));
    }
}
