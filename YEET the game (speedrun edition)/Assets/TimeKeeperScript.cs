using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeKeeperScript : MonoBehaviour
{
    public Text text;
    public Collider endBox;
    public bool running = true;
    private float millis;

    private Vector3 location;

    // Start is called before the first frame update
    void Start()
    {
        millis = 0;
        location = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (running) { 
            millis += Time.deltaTime * 1000;
        }

        text.text = "Time: " + ((float)(((double)millis) / 1000.0)) + " s" +
            "\nSpeed: " + ((float)(GetComponent<Rigidbody>().velocity.magnitude * 3.6)) + " km/t";
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other == endBox) running = false;
    }
}
