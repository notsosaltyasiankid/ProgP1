using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : WalkingEnemy
{
    private float IngameTime;
    private Renderer rendered;
    // Start is called before the first frame update
    void Start()
    {
        hp = 5;
        Speed = 4;
        rendered = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Walking();
        IngameTime += Time.deltaTime;
        if (IngameTime > 0.5) 
        {
            rendered.enabled = true;
        }
        if (IngameTime > 3) 
        {
            rendered.enabled = false;
            IngameTime = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        { 
            HPChecking();
        }
    }
}
