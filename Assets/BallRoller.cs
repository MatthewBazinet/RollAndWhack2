using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallRoller: MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Camera;
    public float maxHp; // maximum and starting HP
    public float curHp; // current HP
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        curHp = maxHp;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(speed * Camera.transform.up * Input.GetAxis("Vertical"));
        rb.AddForce(speed * Camera.transform.right * Input.GetAxis("Horizontal"));

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy") {
            if(collision.rigidbody.velocity.sqrMagnitude > rb.velocity.sqrMagnitude) {

                curHp -= collision.gameObject.GetComponent<EnemyTarget>().damage;
            } else
            {
                collision.gameObject.GetComponent<EnemyTarget>().CurHp -= rb.velocity.magnitude * 10.0f;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (collision.rigidbody.velocity.sqrMagnitude < rb.velocity.sqrMagnitude)
            {
                collision.gameObject.GetComponent<EnemyTarget>().CurHp -= rb.velocity.magnitude * 10.0f;
            }
        }
    }

}
