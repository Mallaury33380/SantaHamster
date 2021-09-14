using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Boulet;
    public int velocity;
    public AudioSource feu;
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            feu.Play();
            float margex = 0f;
            float margey = 0f;
            float margez = 0f;
            Quaternion rotation = Quaternion.identity;

            Vector3 position = new Vector3(transform.position.x + margex, transform.position.y + margey, transform.position.z+margez);
            GameObject newBoulet = Instantiate(Boulet, position, rotation);

            margex = 0.5f;
             position = new Vector3(transform.position.x + margex, transform.position.y + margey, transform.position.z + margez);
            GameObject newBoulet2 = Instantiate(Boulet, position, rotation);

            margex = 1f;
             position = new Vector3(transform.position.x + margex, transform.position.y + margey, transform.position.z + margez);
            GameObject newBoulet3 = Instantiate(Boulet, position, rotation);

            margex = -1f;
             position = new Vector3(transform.position.x + margex, transform.position.y + margey, transform.position.z + margez);
            GameObject newBoulet5 = Instantiate(Boulet, position, rotation);

            margex = -0.5f;
             position = new Vector3(transform.position.x + margex, transform.position.y + margey, transform.position.z + margez);
            GameObject newBoulet4 = Instantiate(Boulet, position, rotation);

            

            
            newBoulet.GetComponent<Rigidbody>().velocity = transform.right * velocity;
            newBoulet2.GetComponent<Rigidbody>().velocity = transform.right * velocity;
            newBoulet3.GetComponent<Rigidbody>().velocity = transform.right * velocity;
            newBoulet4.GetComponent<Rigidbody>().velocity = transform.right * velocity;
            newBoulet5.GetComponent<Rigidbody>().velocity = transform.right * velocity;
        }
    }
}
