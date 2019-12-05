using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public GameObject cameraObject; // the camera object
    public float VelMax; // the maximum amount of speed 
    public float chargeMax; // the maximum charge time
    public Rigidbody rb;
    private float chargeTime;
    public BallRoller br;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        chargeTime = 0.0f; // the amount of time the player has been charging; leave alone
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Fire1") > 0.0f)
        {
            chargeTime += Time.deltaTime;
            br.speed = 0;
         //   rb.constraints = RigidbodyConstraints.FreezePosition;
            if (chargeTime >= chargeMax)
            {
                chargeTime = chargeMax;
            }
        }

        if ((Input.GetAxis("Fire1") <= 0.0f) && (chargeTime > 0.0f))
        {
          //  rb.constraints = RigidbodyConstraints.None;
            rb.velocity = (cameraObject.transform.up * (chargeTime / chargeMax) * VelMax);
            chargeTime = 0.0f; // reset charge time
            br.speed = speed;
        }
    }
}
