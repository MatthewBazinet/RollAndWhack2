using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallRoller: MonoBehaviour
{
    public Rigidbody rb;
    public GameObject Camera;
    public float maxHp; // maximum and starting HP
    public float curHp; // current HP
    // Start is called before the first frame update
    void Start()
    {
        curHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {

        rb.AddForce(Camera.transform.up * Input.GetAxis("Vertical"));
        rb.AddForce(Camera.transform.right * Input.GetAxis("Horizontal"));

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (collision.rigidbody.velocity.sqrMagnitude <= rb.velocity.sqrMagnitude) {
                collision.gameObject.GetComponent<EnemyTarget>().CurHp -= rb.velocity.magnitude * 10.0f;
                collision.rigidbody.AddForce(rb.velocity * 10.0f);
            } else
            {
                curHp -= collision.gameObject.GetComponent<EnemyTarget>().damage;
            }
        }
    }
}
