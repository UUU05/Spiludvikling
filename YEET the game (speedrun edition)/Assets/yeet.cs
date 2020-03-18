using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yeet : MonoBehaviour
{
    public Transform cameraTransform;
    public float YeetForce = 3;
    public float upYeet = 4;
    float x, y, z; //start pos
    // Start is called before the first frame update
    void Start()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            transform.position = new Vector3(x, y, z);
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown("w"))
        {

            GetComponent<Rigidbody>().AddForce(YeetForce * (transform.position - cameraTransform.position) + new Vector3(0, upYeet, 0), ForceMode.Impulse);
            //GetComponent<Rigidbody>().velocity = ;

        }

    }
}
