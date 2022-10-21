using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, -horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
