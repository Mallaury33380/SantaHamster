using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Traineau1;
    public GameObject Traineau2;
    public GameObject Traineau3;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("Score", 0);
        switch (PlayerPrefs.GetInt("Traineau"))
        {
            case 1:
                Instantiate(Traineau1);
                break;
            case 2:
                Instantiate(Traineau2);
                break;
            case 3:
                Instantiate(Traineau3);
                break;
        }
    }

    
}
