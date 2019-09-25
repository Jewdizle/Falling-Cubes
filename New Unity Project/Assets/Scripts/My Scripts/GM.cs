using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public GameObject cube;
    public float area;
    public float height;
    public float freq;

    // Update is called once per frame
    void Update()
    {
        Invoke("SpawnCube", freq);
    }

    private void SpawnCube()
    {
        float x = Random.Range(-10f*area, 10f*area);
        float z = Random.Range(-10f*area, 10f*area);
        Instantiate(cube, new Vector3(x, height, z), Quaternion.identity);
    }
}
