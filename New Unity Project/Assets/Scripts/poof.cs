using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poof: MonoBehaviour {

    void OnTriggerStay(Collider other)
    {
        Destroy(gameObject);
    }
}
