using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPillar : MonoBehaviour
{
    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Instantiate(Prefab, new Vector3(UnityEngine.Random.Range(-10, 10),0, UnityEngine.Random.Range(-10, 10)), Quaternion.identity);
        }
    }
}
