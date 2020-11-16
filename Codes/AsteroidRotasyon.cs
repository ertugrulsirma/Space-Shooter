using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotasyon : MonoBehaviour
{
    Rigidbody fizik;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere*3.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
