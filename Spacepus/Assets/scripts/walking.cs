using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public int hp = 0;
    public GameObject rots;
    public GameObject bullet;
    int moveSpeed = 5;
    int wallleft = 9;
    int wallright = -9;
    int wallup = 5;
    int walldown = -5;
    
    
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.D) && (transform.position.x < wallleft))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && (transform.position.x > wallright))
        {
            transform.position += Vector3.right * -moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W) && (transform.position.y < wallup))
        {
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) && (transform.position.y > walldown))
        {
            transform.position += Vector3.up * -moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet);
        }
        if (hp == 0)
        {
            Destroy(gameObject);
        }

        //test code
        if (Input.GetKeyDown(KeyCode.O))
        {
            Instantiate(rots);
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "rots(Clone)")
        {
            hp = hp - 1;
        }
    }
}
