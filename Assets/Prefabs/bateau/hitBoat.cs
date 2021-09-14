using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitBoat : MonoBehaviour
{
    public int life;
    public AudioSource coule;
    public int value;
   

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boule")
        {
            
            life--;
            if (life == 0)
            {
                Animator animator = this.transform.parent.gameObject.GetComponent<Animator>();
                coule.Play();
                animator.SetBool("coule", true);
                StartCoroutine(LoadDelayed(2f));
            }
        }
    }
    IEnumerator LoadDelayed(float tempsEnSecondes = 5f)
    {
        PlayerPrefs.SetFloat("Score", PlayerPrefs.GetFloat("Score") + value);
        yield return new WaitForSeconds(tempsEnSecondes);
        Destroy(transform.parent.gameObject);
    }
}
