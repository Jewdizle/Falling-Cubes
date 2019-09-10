using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit: MonoBehaviour {

    void OnTriggerStay(Collider other)
    {
        Application.Quit();
    }
}
