using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefab;
    private float wavesize = 100;
    private List<GameObject> enemylist = new List<GameObject>();
    private float otherEnemys = 3;
    private float elapsedTime = 0f;
    // Start is called before the first frame update

    void Start()
    {
        elapsedTime = 0f;
    }
    public void createwave()
    {
        
        for (int i = 0; i < wavesize; i++) 
        {
            enemylist.Add(Instantiate(prefab));
        }
    }

    public void createThree()
    {
        for (int i = 0; i < otherEnemys; i++)
        {
            enemylist.Add(Instantiate(prefab));
        }
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= 1f)
        {
            createThree();
            elapsedTime = 0f;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("pressed W");
            createwave();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < enemylist.Count; i++)
            {
                Destroy(enemylist[i]);
            }
            enemylist.Clear();
        }


    }
    
}
