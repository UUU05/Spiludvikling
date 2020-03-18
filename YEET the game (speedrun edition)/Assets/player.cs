using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Transform cubeTransform;

    public float turnSpeed = 0.4f;

    private float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        x = cubeTransform.position.x;
        y = cubeTransform.position.y;
        z = cubeTransform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += cubeTransform.position - new Vector3(x, y, z);

        x = cubeTransform.position.x;
        y = cubeTransform.position.y;
        z = cubeTransform.position.z;

        if (Input.GetKey("d"))
        {
            transform.RotateAround(cubeTransform.position, Vector3.up, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.RotateAround(cubeTransform.position, Vector3.up, -turnSpeed * Time.deltaTime);
        }
    }
}
