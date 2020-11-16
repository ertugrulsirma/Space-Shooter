using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FxControle : MonoBehaviour
{
    Rigidbody fizik;

    void Start()
    {
         fizik = GetComponent<Rigidbody>();
         fizik.velocity = transform.forward*8;
        
    }

}
