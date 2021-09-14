using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attaque : MonoBehaviour
{
    public GameObject boulet;
    public AudioSource music;
    public float vitesse;
    
    
    public void OnTriggerEnter(Collider other)
    {
        Animator animator = this.transform.parent.gameObject.GetComponent<Animator>();
        if (other.tag == "Player")
        {
            animator.SetBool("attaques", true);
            music.Play();


            float margex = 0.1f;
            float margey = 0f;
            Vector3 position = new Vector3(transform.position.x + margex, transform.position.y + margey, transform.position.z);
            Quaternion rotation = Quaternion.identity;

            GameObject newBoulet = Instantiate(boulet, position, rotation);
            newBoulet.GetComponent<Rigidbody>().velocity=transform.forward * vitesse;
        }
    }
    public void OnTriggerExit()
    {
        Animator animator = this.transform.parent.gameObject.GetComponent<Animator>();
        animator.SetBool("attaques", false);
    }
    
}
