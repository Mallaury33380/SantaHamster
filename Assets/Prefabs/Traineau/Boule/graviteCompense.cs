using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graviteCompense : MonoBehaviour
{
    public int valGravite;


    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(0, valGravite*Time.deltaTime, 0);
    }
}
