﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruction : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boule")
        {
            Destroy(gameObject);
        }
    }
}
