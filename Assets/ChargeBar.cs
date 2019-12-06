using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeBar : MonoBehaviour
{

    public GameObject Sphere;
    float chargeTime = 0;
    float maxCharge = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sphere.activeInHierarchy)
        {
            chargeTime = GameObject.Find("Sphere (Player)").GetComponent<Dash>().chargeTime;
            maxCharge = GameObject.Find("Sphere (Player)").GetComponent<Dash>().chargeMax;
        }
        else
        {
            chargeTime = GameObject.Find("Cube (Player)").GetComponent<PlayerController>().chargeTime;
            maxCharge = GameObject.Find("Cube (Player)").GetComponent<PlayerController>().chargeMax;
        }
        chargeTime = chargeTime / maxCharge;

        Vector3 scale = transform.localScale;
        Vector3 pos = transform.localPosition;
        scale.x = 1 - chargeTime;

        transform.localScale = scale;
    }
}
