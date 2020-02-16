using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    private Rigidbody rb;
    public int missileForce=1000;
    void Start()
    {
       rb=GetComponent<Rigidbody>(); 
    }

    
    void Update()
    {
        rb.AddForce(transform.forward*missileForce);
    }
}
