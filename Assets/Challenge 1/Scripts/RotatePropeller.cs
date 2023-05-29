using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour
{   
    public Vector3 rotationSpeed;
    // Start is called before the first frame update
    void Awake()
    {
        rotationSpeed = new Vector3(0f, 0f, 50 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed, Space.Self);
    }
}
