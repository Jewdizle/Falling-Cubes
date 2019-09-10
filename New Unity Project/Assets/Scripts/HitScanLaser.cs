using System.Collections;
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
            /*int layerMask = 1 << 8;
            layerMask = ~layerMask;

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit, Mathf.Infinity, layerMask))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Debug.Log("Did Hit");
                
                
            }
            else
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
                Debug.Log("Did Not Hit");
                Shoot();
            }*/
        }
    }

    public void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);  
    }
}
