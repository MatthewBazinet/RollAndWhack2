using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallRoller: MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Camera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        rb.AddForce(Camera.transform.up * Input.GetAxis("Vertical"));
        rb.AddForce(Camera.transform.right * Input.GetAxis("Horizontal"));
    }
}
