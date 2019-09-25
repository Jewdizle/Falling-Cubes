﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScanLaser : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }         
    }

    public void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation); 
    }
}
