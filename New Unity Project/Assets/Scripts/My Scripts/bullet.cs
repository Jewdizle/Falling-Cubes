using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody rb;
    public float bulletSpeed;

    public float deathWait;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, deathWait);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * bulletSpeed);
    }
}

