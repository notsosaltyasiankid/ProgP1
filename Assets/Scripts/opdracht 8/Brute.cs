using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : WalkingEnemy
{ 
    void Start()
    {
        hp = 10;
        Speed = 2;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        if (other.gameObject.CompareTag("Bullet"))
        {
            HPChecking();
        }
    }
}
