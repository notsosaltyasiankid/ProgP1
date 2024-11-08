using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WalkingEnemy : MonoBehaviour
{
    public int hp;
    public float Speed;

    public Vector3 endPoint;
    void Update()
    {
        Walking();
    }

    public void Walking()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPoint, Speed * Time.deltaTime);
    }

    public void HPChecking()
    {
        hp -= 1;
        if (hp < 0)
        {
            Destroy(gameObject); 
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
