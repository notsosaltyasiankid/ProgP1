using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float rotation = 0;
    [SerializeField] float speed = 10;
    [SerializeField] float rotationspeed = 140;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position += Input.GetAxisRaw("Vertical") * transform.forward * speed * Time.deltaTime;
        rotation += Input.GetAxisRaw("Horizontal") * rotationspeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(new Vector3(0, rotation, 0)); 
    }
}
