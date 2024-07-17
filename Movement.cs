using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float rotationspeed;
    // Update is called once per frame
    void Update()
    {
        // using keyboard input
        if (Input.GetKey("w")){
            // moves the object according to the vector 3 right multiplied by the time and speed (the object is not oriented forward so the object needs to go right instead of forward)
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey("a")){
            gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("d")){
            gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey("s")){
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        // using mouse input
        float mouseX = Input.GetAxis("Mouse X") * rotationspeed * Time.deltaTime;
        // pitch = xaxis, yaw = yaxis, roll = zaxis
        transform.Rotate(0, mouseX, 0);
    }
    }