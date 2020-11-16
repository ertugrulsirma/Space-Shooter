using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHareket : MonoBehaviour
{
    Rigidbody fizik;
    

    void Start()
    {
         fizik = GetComponent<Rigidbody>();
         fizik.velocity = transform.forward*-3;
        
    }
}
