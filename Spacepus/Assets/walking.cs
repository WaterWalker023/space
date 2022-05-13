using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public int moveSpeed = 5;
    int wallright = 9;
    int wallleft = -9;
    int wallup = 5;
    int walldown = -5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) && (transform.position.x < wallright))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && (transform.position.x > wallleft))
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
    }
}
