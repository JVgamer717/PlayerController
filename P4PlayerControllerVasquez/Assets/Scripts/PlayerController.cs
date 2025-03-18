using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchkey;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    void Update() 
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move the Vechile forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // Rotates the car based on horizontal input 
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        if (Input.GetKeyDown(switchkey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
    }
}
