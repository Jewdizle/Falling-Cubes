using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
     int hits = 0;
     public int hitCount;

    public float radius = 5.0F;
    public float power = 10.0F;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision collision)
     {
        if (hits < hitCount)
        {
            hits++;
        }
        else
        {
            rb.AddExplosionForce(power, transform.position, radius);       
        }
        if(hits == hitCount+1)
        {
            GM.Dest
        }
        
    }
}
