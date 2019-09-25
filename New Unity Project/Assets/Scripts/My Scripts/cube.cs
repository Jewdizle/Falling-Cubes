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
    public GameObject explosion;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.tag == "Bullet")
        {
            hits++;
            if(hits == hitCount)
            {
                 Destroy(gameObject);
                 Instantiate(explosion, transform.position, Quaternion.identity);
            }        
        }
    }

    private void Update()
    {
        if (transform.position.y < -1000)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        rb.AddExplosionForce(power, transform.position, radius);       
    }
}
