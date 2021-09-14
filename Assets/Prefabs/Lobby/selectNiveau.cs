using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectNiveau : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject affiche;
    public int numeroNiveau;
    public AudioSource son;
    public int vitesse;


    public void OnTriggerEnter()
    {
        son.Play();
        SceneManager.LoadScene("Niveau" + numeroNiveau.ToString());
        PlayerPrefs.SetInt("Niveau", numeroNiveau);
    }

    // Update is called once per frame
    void Update()
    {
        affiche.GetComponent<Rigidbody>().AddTorque(new Vector3(0, vitesse, 0));
    }
}
